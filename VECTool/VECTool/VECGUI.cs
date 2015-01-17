using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using VECMATLIB;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

namespace VECTool
{
    public partial class VECGUI : Form
    {
       private VECState vec;
       private Transformation matlab_transform;
       private MWNumericArray predicted_commands;
       private MWNumericArray aligned_commands;

        public VECGUI(ref VECState vecstate)
        {
            int[] size = new int[2] { 10, 5 };
            matlab_transform = new Transformation();
            predicted_commands = new MWNumericArray(size);
            size[1] = 3;
            aligned_commands = new MWNumericArray(size);

            vec = vecstate;
            InitializeComponent();
            //set default values for user input
            txtLTMeasureFile.Text = "C:\\Users\\Gus\\Desktop\\vec\\VECTool\\long.txt";
            txtSTMeasureFile.Text = "C:\\Users\\Gus\\Desktop\\vec\\VECTool\\short.txt";
            txtCommandsFile.Text = "C:\\Users\\Gus\\Desktop\\vec\\VECTool\\commands.txt";
            txtLTL.Text = "12.0"; //long tl 
            txtLTO.Text = "6.7"; //long to
            txtSTL.Text = "8"; //short t1
            txtSTO.Text = "1.0";  //short to
            cboControllerProf.Text = "Profile 1"; //contprof
            vec.logRTbox = logRTbox;
        }

        // Cancel Button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Run Button
        private void btnRun_Click(object sender, EventArgs e)
        {
            
            vec.longToolLength = Convert.ToDouble(txtLTL.Text);
            vec.longToolOffset = Convert.ToDouble(txtLTO.Text);
            vec.shortToolLength = Convert.ToDouble(txtSTL.Text);
            vec.shortToolOffset = Convert.ToDouble(txtSTO.Text);
            vec.machineConfiguration = 0;

            if (cboControllerProf.Text == "Profile 1")
            {
                vec.controllerProfile = 1;
            }
            else if (cboControllerProf.Text == "Profile 2")
            {
                vec.controllerProfile = 2;
            }
            else if (cboControllerProf.Text == "Profile 3")
            {
                vec.controllerProfile = 3;
            }
            else if (cboControllerProf.Text == "Profile 4")
            {
                vec.controllerProfile = 4;
            }

            string[] lines = System.IO.File.ReadAllLines(txtSTMeasureFile.Text);
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                if (!vec.rawShortTool.ContainsKey(line.Split(',')[0]))
                {
                    vec.rawShortTool.Add(line.Split(',')[0], new List<double>());
                    vec.rawShortTool[line.Split(',')[0]].Add(Convert.ToDouble((line.Split(',')[1])));
                    vec.rawShortTool[line.Split(',')[0]].Add(Convert.ToDouble((line.Split(',')[2])));
                    vec.rawShortTool[line.Split(',')[0]].Add(Convert.ToDouble((line.Split(',')[3])));
                    if (vec.rawShortTool[line.Split(',')[0]].Count > 3)
                    {
                        throw new Exception("There are too many items in the Short Tool Measurements at " + line.Split(',')[0]);
                    }
                }
            }
            logRTbox.Text = logRTbox.Text + "Successfully loaded Short Tool measurements.\n";

            lines = System.IO.File.ReadAllLines(txtLTMeasureFile.Text);
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                if (!vec.rawLongTool.ContainsKey(line.Split(',')[0]))
                {
                    vec.rawLongTool.Add(line.Split(',')[0], new List<double>());
                    vec.rawLongTool[line.Split(',')[0]].Add(Convert.ToDouble((line.Split(',')[1])));
                    vec.rawLongTool[line.Split(',')[0]].Add(Convert.ToDouble((line.Split(',')[2])));
                    vec.rawLongTool[line.Split(',')[0]].Add(Convert.ToDouble((line.Split(',')[3])));
                    if (vec.rawLongTool[line.Split(',')[0]].Count > 3)
                    {
                        throw new Exception("There are too many items in the Long Tool Measurements at " + line.Split(',')[0]);
                    }
                }
            }
            logRTbox.Text = logRTbox.Text + "Successfully loaded Long Tool measurements.\n";

            lines = System.IO.File.ReadAllLines(txtCommandsFile.Text);
            int counter = 0;
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                if (!vec.Commands.ContainsKey(counter.ToString()))
                {
                    vec.Commands.Add(counter.ToString(), new List<double>());
                    vec.Commands[counter.ToString()].Add(Convert.ToDouble((line.Split(',')[0])));
                    vec.Commands[counter.ToString()].Add(Convert.ToDouble((line.Split(',')[1])));
                    vec.Commands[counter.ToString()].Add(Convert.ToDouble((line.Split(',')[2])));
                    vec.Commands[counter.ToString()].Add(Convert.ToDouble((line.Split(',')[3])));
                    vec.Commands[counter.ToString()].Add(Convert.ToDouble((line.Split(',')[4])));
                }
                if (vec.Commands[counter.ToString()].Count > 5)
                {
                    throw new Exception("There are too many items in the Long Tool Measurements at line " + (counter+1).ToString());
                }
                counter++;
            }
            logRTbox.Text = logRTbox.Text + "Successfully loaded command position.\n";

            ToolMeasurementHandler tmh = new ToolMeasurementHandler(vec);
            if (tmh.alignMeasurements() != 0) { return; }
            
            string tmp = "";
            foreach (KeyValuePair<String, List<double>> mst in vec.MALongTool)
            {
                tmp += mst.Key + " ";
                foreach (double m in mst.Value)
                {
                    tmp += Convert.ToString(m) + " ";
                }
                tmp += "\n";
            }
            logRTbox.Text = logRTbox.Text + tmp;
            logRTbox.Text = logRTbox.Text + "Successfully aligned Long Tool positions.\n";
            
            tmp = "";
            foreach (KeyValuePair<String, List<double>> mst in vec.MAShortTool)
            {
                tmp += mst.Key + " ";
                foreach (double m in mst.Value)
                {
                    tmp += Convert.ToString(m) + " ";
                }
                tmp += "\n";
            }
            logRTbox.Text = logRTbox.Text + tmp;
            logRTbox.Text = logRTbox.Text + "Successfully aligned Short Tool positions.\n";

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    int[] index = new int[2] { i, j };
                    predicted_commands[i, j] = 1.0;
                }
            }
            
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    int[] index = new int[2] { i, j };
                    aligned_commands[index] = vec.MALongTool.Values.ElementAt(i-1).ElementAt(j-1);
                }
            }
            
            vec.lt_transformation_matrix = matlab_transform.LTransform(1, aligned_commands ,predicted_commands, vec.longToolLength);
            tmp = "";
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    int[] index = new int[2] { i, j };
                    tmp += vec.lt_transformation_matrix[0][index].ToString() + ',';
                }
                tmp += '\n';
            }
            logRTbox.Text = logRTbox.Text + tmp;
            logRTbox.Text = logRTbox.Text + "Calculated long tool transformation matrix.\n";

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    int[] index = new int[2] { i, j };
                    aligned_commands[index] = vec.MAShortTool.Values.ElementAt(i - 1).ElementAt(j - 1);
                }
            }

            vec.st_transformation_matrix = matlab_transform.LTransform(1, aligned_commands, predicted_commands, vec.shortToolLength);
            tmp = "";
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    int[] index = new int[2] { i, j };
                    tmp += vec.st_transformation_matrix[0][index].ToString() + ',';
                }
                tmp += '\n';
            }
            logRTbox.Text = logRTbox.Text + tmp;
            logRTbox.Text = logRTbox.Text + "Calculated short tool transformation matrix.\n";
        }
        // Long Tool Measurements File Dialogue Button
        private void btnLTMFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            if(dr==DialogResult.OK)
            {
                txtLTMeasureFile.Text = ofd.FileName;
            }


        }

        // Short Tool Measurements File Dialogue Button
        private void btnSTMFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtSTMeasureFile.Text = ofd.FileName;
            }
     
        }

        private void btnBackConfig_Click(object sender, EventArgs e)
        {
            
        }

        private void btnForwardConfig_Click(object sender, EventArgs e)
        {
            //picMachineConfig.BackgroundImage = global::VECTool.Properties.Resources.boeingLogo2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
    }
}

/*
string tempString;
tempString = "Aligned Long:\n";
foreach (KeyValuePair<String,List<double>> mlt in vec.MALongTool)
{
    tempString += mlt.Key + " ";
    foreach (double m in mlt.Value)
    {
        tempString += Convert.ToString(m) + " ";
    }
    tempString += "\n";
}
tempString += "\nAligned Short:\n";
foreach (KeyValuePair<String, List<double>> mst in vec.MAShortTool)
{
    tempString += mst.Key + " ";
    foreach (double m in mst.Value)
    {
        tempString += Convert.ToString(m) + " ";
    }
    tempString += "\n";
}
//logRTbox.Text = tempString;
//MessageBox.Show(tempString);

            string tempString = "";
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    int[] index = new int[2] { i, j };
                    tempString += Convert.ToString(transformation_matrix[0][index]);
                    if (j != 4)
                    {
                        tempString += ',';
                    }
                }
                tempString += '\n';
            }
            vec.logRTbox.Text = tempString;
 richTextBox1.Text = "Long Tool Length: " + Convert.ToString(vec.longToolLength) + "\n"
                               + "Long Tool Offset: " + Convert.ToString(vec.longToolOffset) + "\n"
                               + "Short Tool Length: " + Convert.ToString(vec.shortToolLength) + "\n"
                               + "Short Tool Offset: " + Convert.ToString(vec.shortToolOffset) + "\n"
                               + "Machine Configuration: " + Convert.ToString(vec.machineConfiguration) + "\n"
                               + "Controller Profile: " + Convert.ToString(vec.controllerProfile);
            string tmp = "";
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                { 
                    int[] index = new int[2] {i,j};
                    tmp += vec.lt_transformation_matrix[0][index].ToString();
                }
                tmp += '\n';
            }
            logRTbox.Text = logRTbox.Text + tmp;
            MessageBox.Show(tmp);
 
 */