using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.IO;
using System.Text;

namespace VECTool
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //http://msdn.microsoft.com/en-us/library/db5x7c0d.aspx
            
            //How to add a new row to the longshort tool entries
            //rawLongShortTool.Add(1, new List<double>());
            //How to populate the list for a longshort tool entry
            //rawLongShortTool[1].Add(10.5);
            
            //Read long and short tool measurements from file
            
            

            //MessageBox.Show(temp.Split(',')[0]);
            VECState vecstate = new VECState(0, 0, 0.0, 0.0, 0.0, 0.0);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VECGUI(ref vecstate));
            
        }

    }
}
