using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathWorks.MATLAB.NET.Arrays;

namespace VECTool
{
    public class VECState
    {
        public Dictionary<String, List<double>> rawLongTool;
        public Dictionary<String, List<double>> MALongTool;
        public Dictionary<String, List<double>> CALongTool;
        
        public Dictionary<String, List<double>> rawShortTool;
        public Dictionary<String, List<double>> MAShortTool;
        public Dictionary<String, List<double>> CAShortTool;

        public Dictionary<String, List<double>> Commands;

        public System.Windows.Forms.RichTextBox logRTbox;

        public int currentStep { get; set; }

        public int machineConfiguration { get; set; }
        public int controllerProfile { get; set; }
        public double longToolLength { get; set; }
        public double longToolOffset { get; set; }
        public double shortToolLength { get; set; }
        public double shortToolOffset { get; set; }

        public MWArray[] lt_transformation_matrix;

        public MWArray[] st_transformation_matrix;

        public VECState(int mc, int cp, double ltl, double lto, double stl, double sto)
        {
            logRTbox = null;

            rawLongTool = new Dictionary<String, List<double>>();
            MALongTool = new Dictionary<String, List<double>>();
            CALongTool = new Dictionary<String, List<double>>();

            rawShortTool = new Dictionary<String, List<double>>();
            MAShortTool = new Dictionary<String, List<double>>();
            CAShortTool = new Dictionary<String, List<double>>();

            Commands = new Dictionary<String, List<double>>();

            currentStep = 0;
            machineConfiguration = mc;
            controllerProfile = cp;
            longToolLength = ltl;
            longToolOffset = lto;
            shortToolLength = stl;
            shortToolOffset = sto;

            lt_transformation_matrix = null;
            st_transformation_matrix = null;
        }
    }

}
