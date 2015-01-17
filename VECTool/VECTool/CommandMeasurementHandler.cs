using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VECTool
{
    class CommandMeasurementHandler
    {
        private VECState m_state;
        const int DIMENSION = 3;

        public CommandMeasurementHandler(VECState state)
        {
            m_state = state;
        }

        public void CommandMeasurements()
        {
            if(commandErrorCheck())
            {
                //Try deleting elements or stopping the program
            }

            //pass elements to ILM and GA
        }

        private bool commandErrorCheck()
        {
            bool error = false;

            foreach (KeyValuePair<String, List<double>> pair in m_state.MALongTool)
            {
                double[] MA_coordinates = pair.Value.ToArray();
                double[] CA_coordinates;
                double MA_norm, CA_norm;

                for (int i = 0; i < DIMENSION; ++i)
                    MA_coordinates[i] = Math.Pow(MA_coordinates[i], 2);

                MA_norm = Math.Sqrt(MA_coordinates.Sum());

                if (m_state.CALongTool.ContainsKey(pair.ToString()))
                {
                    CA_coordinates = m_state.CALongTool[pair.ToString()].ToArray();

                    for (int i = 0; i < DIMENSION; ++i)
                        CA_coordinates[i] = Math.Pow(CA_coordinates[i], 2);

                    CA_norm = Math.Sqrt(CA_coordinates.Sum());

                    if (Math.Abs(CA_norm - MA_norm) > m_state.longToolOffset)
                        error = true;
                }
            }

            return error;
        }

    }
}
