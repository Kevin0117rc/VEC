using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VECTool
{
    /*
     * ToolMeasurementHandler is responsible for fixing misaligned
     * tool measurements.
     */
    class ToolMeasurementHandler
    {
        //Member variable declaration
        private VECState m_state;

        /*
         * ToolMeasurementHandler constructor
         */
        public ToolMeasurementHandler(VECState state)
        {
            m_state = state;
        }

        /*
         * Calculates the Euclidean distance between the long and short 
         * coordinates.
         * @pre:    long and short coordinates fit <X, Y, Z> format
         * @param:  longCoord  - <X, Y, Z> long tool coordinate
         *          shortCoord - <X, Y, Z> short tool coordinate
         * @post:   Euclidean distance between coordinates is calculated
         * @return: Distance between long and short tool measurements
         */
        private double distance(List<double> longCoord, List<double> shortCoord)
        {
            double distance   = 0.0; //Keep track of squared differences
            double difference = 0.0; //Reduce subtraction calculations

            int lCount = longCoord.Count();
            int sCount = shortCoord.Count();

            for (int c = 0; c < lCount && c < sCount; c++)
            {
                difference = longCoord[c]-shortCoord[c];
                distance += difference * difference;
            }
            return Math.Sqrt(distance); //Calculate Euclidean distance
        }

        /*
        * Align long and short tool measurements
        * @pre:  none
        * @post: Aligned measurements stored in the VECState's MALongTool 
        *        and MAShortTool
        * @return: error signal (0=successful)
        */
        public int alignMeasurements()
        {
            //Initialize local variables
            List<double> distances   = new List<double>();
            double       newDistance = 0.0;

            int lTotal = m_state.rawLongTool.Count();
            int sTotal = m_state.rawShortTool.Count();

            int lCount = 0, lOffset = 0;
            int sCount = 0, sOffset = 0;

            //Aligned count must be at least 10% of original count
            int MINIUM_ALIGNED_COUNT = (int)(((lTotal < sTotal) ? lTotal : sTotal) * 0.10);

            int initCount = -1, initOffset = 0;
            bool initTryLong = false;

            double mean   = 0.0;
            double stdDev = 0.0;

            bool foundMatch = false;
            bool tryingLong = false;

            double toolDifference = Math.Abs(m_state.longToolLength - m_state.shortToolLength);

            KeyValuePair<String,List<double>> element;

            //Correct misalignments
            m_state.MALongTool.Clear();
            m_state.MAShortTool.Clear();
            for (; lCount < lTotal && sCount < sTotal; lCount+=lOffset+1, sCount+=sOffset+1)
            {
                foundMatch = false;
                tryingLong = false;
                lOffset    = 0;
                sOffset    = 0;
                mean       = 0.0;
                stdDev     = 0.0;

                if (distances.Count() > 1 && 
                    lCount-initCount > MINIUM_ALIGNED_COUNT && sCount-initCount > MINIUM_ALIGNED_COUNT)
                {
                    mean = distances.Average();
                    stdDev = distances.Sum(d => Math.Pow(d - mean, 2)); //sum of deviations
                    stdDev = Math.Sqrt(stdDev / (distances.Count() - 1));
                }
                else if (distances.Count() > 0)
                {
                    mean = distances.Average();
                    stdDev = 0.01; //Arbitrarily large value
                }
                else
                {
                    mean = 0.0;
                    stdDev = 1000.0; //Arbitrarily large value
                }

                //TODO Check for invalid values at start of measurements
                while (!foundMatch && ((lCount+lOffset)<lTotal && (sCount+sOffset)<sTotal))
                {
                    newDistance = distance(
                        m_state.rawLongTool.ElementAt(lCount + ((tryingLong) ? lOffset : 0)).Value,
                        m_state.rawShortTool.ElementAt(sCount + ((!tryingLong) ? sOffset : 0)).Value);

                    if (newDistance <= toolDifference+(0.1*toolDifference) && newDistance >= toolDifference-(0.1*toolDifference) &&
                        (newDistance < (mean + (10.0 * stdDev))) && (newDistance > (mean - (10.0 * stdDev))))
                    {
                        distances.Add(newDistance);

                        if(!tryingLong) 
                            lOffset = 0;
                        else 
                            sOffset = 0;

                        element = m_state.rawLongTool.ElementAt(lCount + lOffset);
                        m_state.MALongTool[element.Key] = element.Value;

                        element = m_state.rawShortTool.ElementAt(sCount + sOffset);
                        m_state.MAShortTool[element.Key] = element.Value;

                        foundMatch = true;
                    }
                    else if ((!tryingLong && (lCount+lOffset+1)<lTotal) || (sCount+sOffset+1)>=sTotal)
                    {
                        lOffset++;
                        tryingLong = true;
                    }
                    else
                    {
                        sOffset++;
                        tryingLong = false;
                    }
                }

                if ((lCount + lOffset) >= lTotal && (sCount + sOffset) >= sTotal)
                {
                    lOffset = sOffset = 0;
                }

                //Handle incorrect initial values
                if ((distances.Count() <= MINIUM_ALIGNED_COUNT) && 
                    (lCount + lOffset + 1 >= lTotal) && (sCount + sOffset + 1 >= sTotal))
                {
                    distances.Clear();
                    m_state.MALongTool.Clear();
                    m_state.MAShortTool.Clear();

                    lOffset = sOffset = 0;
                    if ((!initTryLong && (initCount + initOffset + 1) < lTotal) || ((initCount + initOffset + 1) >= sTotal))
                    {
                        initOffset++;
                        initTryLong = true;
                        lCount = sCount = initCount;
                        lCount += initOffset;
                    }
                    else if ((initCount + initOffset + 1) < sTotal)
                    {
                        if (!initTryLong)
                        {
                            initOffset++;
                        }
                        initTryLong = false;
                        lCount = sCount = initCount;
                        sCount += initOffset;
                    }
                    else if (initCount + 1 < lCount || initCount + 1 < sCount)
                    {
                        initCount++;
                        lCount = sCount = initCount;
                        initOffset = 0;
                        initTryLong = false;
                    }
                    else
                    {
                        //THROW ERROR: NEED NEW VALUES!
                        m_state.logRTbox.Text += "\nError: Tool Measurement Alignment Incorrect\nPlease provide new values!\n";
                        return 1;
                    }
                }
            }

            if (distances.Count() < MINIUM_ALIGNED_COUNT)
            {
                //THROW ERROR: NEED NEW VALUES!
                m_state.logRTbox.Text += "\nError: Tool Measurement Alignment Incorrect\nPlease provide new values!\n";
                return 1;
            }
            
            /*string tempString;
            tempString = "Aligned Long:\n";
            foreach (KeyValuePair<String,List<double>> mlt in m_state.MALongTool)
            {
                tempString += mlt.Key + " ";
                foreach (double m in mlt.Value)
                {
                    tempString += Convert.ToString(m) + " ";
                }
                tempString += "\n";
            }
            tempString += "\nAligned Short:\n";
            foreach (KeyValuePair<String, List<double>> mst in m_state.MAShortTool)
            {
                tempString += mst.Key + " ";
                foreach (double m in mst.Value)
                {
                    tempString += Convert.ToString(m) + " ";
                }
                tempString += "\n";
            }
            m_state.logRTbox.Text += tempString;*/
            return 0;
        }
    }
}
