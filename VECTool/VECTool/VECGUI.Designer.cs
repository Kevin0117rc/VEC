namespace VECTool
{
    partial class VECGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadLTMFile = new System.Windows.Forms.Button();
            this.btnLoadSTMFile = new System.Windows.Forms.Button();
            this.txtLTMeasureFile = new System.Windows.Forms.TextBox();
            this.txtSTMeasureFile = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLTL = new System.Windows.Forms.TextBox();
            this.txtLTO = new System.Windows.Forms.TextBox();
            this.txtSTL = new System.Windows.Forms.TextBox();
            this.txtSTO = new System.Windows.Forms.TextBox();
            this.cboControllerProf = new System.Windows.Forms.ComboBox();
            this.lblLongTool = new System.Windows.Forms.Label();
            this.lblShortTool = new System.Windows.Forms.Label();
            this.lblLTL = new System.Windows.Forms.Label();
            this.lblLTO = new System.Windows.Forms.Label();
            this.lblSTL = new System.Windows.Forms.Label();
            this.lblSTO = new System.Windows.Forms.Label();
            this.lblCProf = new System.Windows.Forms.Label();
            this.logRTbox = new System.Windows.Forms.RichTextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblMachineConfig = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadCMDFile = new System.Windows.Forms.Button();
            this.txtCommandsFile = new System.Windows.Forms.TextBox();
            this.btnBackConfig = new System.Windows.Forms.Button();
            this.btnForwardConfig = new System.Windows.Forms.Button();
            this.picMachineConfig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMachineConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadLTMFile
            // 
            this.btnLoadLTMFile.Location = new System.Drawing.Point(43, 34);
            this.btnLoadLTMFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadLTMFile.Name = "btnLoadLTMFile";
            this.btnLoadLTMFile.Size = new System.Drawing.Size(22, 19);
            this.btnLoadLTMFile.TabIndex = 0;
            this.btnLoadLTMFile.Text = "...";
            this.btnLoadLTMFile.UseVisualStyleBackColor = true;
            this.btnLoadLTMFile.Click += new System.EventHandler(this.btnLTMFile_Click);
            // 
            // btnLoadSTMFile
            // 
            this.btnLoadSTMFile.Location = new System.Drawing.Point(43, 83);
            this.btnLoadSTMFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadSTMFile.Name = "btnLoadSTMFile";
            this.btnLoadSTMFile.Size = new System.Drawing.Size(22, 19);
            this.btnLoadSTMFile.TabIndex = 1;
            this.btnLoadSTMFile.Text = "...";
            this.btnLoadSTMFile.UseVisualStyleBackColor = true;
            this.btnLoadSTMFile.Click += new System.EventHandler(this.btnSTMFile_Click);
            // 
            // txtLTMeasureFile
            // 
            this.txtLTMeasureFile.Location = new System.Drawing.Point(69, 35);
            this.txtLTMeasureFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtLTMeasureFile.Name = "txtLTMeasureFile";
            this.txtLTMeasureFile.Size = new System.Drawing.Size(282, 20);
            this.txtLTMeasureFile.TabIndex = 2;
            // 
            // txtSTMeasureFile
            // 
            this.txtSTMeasureFile.Location = new System.Drawing.Point(69, 85);
            this.txtSTMeasureFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtSTMeasureFile.Name = "txtSTMeasureFile";
            this.txtSTMeasureFile.Size = new System.Drawing.Size(282, 20);
            this.txtSTMeasureFile.TabIndex = 3;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(28, 542);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(68, 19);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(122, 542);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 19);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtLTL
            // 
            this.txtLTL.Location = new System.Drawing.Point(55, 183);
            this.txtLTL.Margin = new System.Windows.Forms.Padding(2);
            this.txtLTL.Name = "txtLTL";
            this.txtLTL.Size = new System.Drawing.Size(104, 20);
            this.txtLTL.TabIndex = 6;
            // 
            // txtLTO
            // 
            this.txtLTO.Location = new System.Drawing.Point(234, 183);
            this.txtLTO.Margin = new System.Windows.Forms.Padding(2);
            this.txtLTO.Name = "txtLTO";
            this.txtLTO.Size = new System.Drawing.Size(104, 20);
            this.txtLTO.TabIndex = 7;
            // 
            // txtSTL
            // 
            this.txtSTL.Location = new System.Drawing.Point(55, 241);
            this.txtSTL.Margin = new System.Windows.Forms.Padding(2);
            this.txtSTL.Name = "txtSTL";
            this.txtSTL.Size = new System.Drawing.Size(104, 20);
            this.txtSTL.TabIndex = 8;
            // 
            // txtSTO
            // 
            this.txtSTO.Location = new System.Drawing.Point(234, 241);
            this.txtSTO.Margin = new System.Windows.Forms.Padding(2);
            this.txtSTO.Name = "txtSTO";
            this.txtSTO.Size = new System.Drawing.Size(104, 20);
            this.txtSTO.TabIndex = 9;
            // 
            // cboControllerProf
            // 
            this.cboControllerProf.FormattingEnabled = true;
            this.cboControllerProf.Items.AddRange(new object[] {
            "Profile 1",
            "Profile 2",
            "Profile 3",
            "Profile 4",
            "Custom Profile"});
            this.cboControllerProf.Location = new System.Drawing.Point(56, 292);
            this.cboControllerProf.Margin = new System.Windows.Forms.Padding(2);
            this.cboControllerProf.Name = "cboControllerProf";
            this.cboControllerProf.Size = new System.Drawing.Size(104, 21);
            this.cboControllerProf.TabIndex = 18;
            // 
            // lblLongTool
            // 
            this.lblLongTool.AutoSize = true;
            this.lblLongTool.Location = new System.Drawing.Point(67, 12);
            this.lblLongTool.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLongTool.Name = "lblLongTool";
            this.lblLongTool.Size = new System.Drawing.Size(146, 13);
            this.lblLongTool.TabIndex = 19;
            this.lblLongTool.Text = "Long Tool Measurements File";
            // 
            // lblShortTool
            // 
            this.lblShortTool.AutoSize = true;
            this.lblShortTool.Location = new System.Drawing.Point(67, 64);
            this.lblShortTool.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShortTool.Name = "lblShortTool";
            this.lblShortTool.Size = new System.Drawing.Size(147, 13);
            this.lblShortTool.TabIndex = 20;
            this.lblShortTool.Text = "Short Tool Measurements File";
            // 
            // lblLTL
            // 
            this.lblLTL.AutoSize = true;
            this.lblLTL.Location = new System.Drawing.Point(53, 161);
            this.lblLTL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLTL.Name = "lblLTL";
            this.lblLTL.Size = new System.Drawing.Size(91, 13);
            this.lblLTL.TabIndex = 21;
            this.lblLTL.Text = "Long Tool Length";
            // 
            // lblLTO
            // 
            this.lblLTO.AutoSize = true;
            this.lblLTO.Location = new System.Drawing.Point(231, 161);
            this.lblLTO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLTO.Name = "lblLTO";
            this.lblLTO.Size = new System.Drawing.Size(86, 13);
            this.lblLTO.TabIndex = 22;
            this.lblLTO.Text = "Long Tool Offset";
            // 
            // lblSTL
            // 
            this.lblSTL.AutoSize = true;
            this.lblSTL.Location = new System.Drawing.Point(53, 217);
            this.lblSTL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSTL.Name = "lblSTL";
            this.lblSTL.Size = new System.Drawing.Size(92, 13);
            this.lblSTL.TabIndex = 23;
            this.lblSTL.Text = "Short Tool Length";
            // 
            // lblSTO
            // 
            this.lblSTO.AutoSize = true;
            this.lblSTO.Location = new System.Drawing.Point(231, 217);
            this.lblSTO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSTO.Name = "lblSTO";
            this.lblSTO.Size = new System.Drawing.Size(87, 13);
            this.lblSTO.TabIndex = 24;
            this.lblSTO.Text = "Short Tool Offset";
            // 
            // lblCProf
            // 
            this.lblCProf.AutoSize = true;
            this.lblCProf.Location = new System.Drawing.Point(52, 269);
            this.lblCProf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCProf.Name = "lblCProf";
            this.lblCProf.Size = new System.Drawing.Size(83, 13);
            this.lblCProf.TabIndex = 25;
            this.lblCProf.Text = "Controller Profile";
            // 
            // logRTbox
            // 
            this.logRTbox.Location = new System.Drawing.Point(28, 351);
            this.logRTbox.Margin = new System.Windows.Forms.Padding(2);
            this.logRTbox.Name = "logRTbox";
            this.logRTbox.Size = new System.Drawing.Size(578, 167);
            this.logRTbox.TabIndex = 26;
            this.logRTbox.Text = "";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(25, 324);
            this.lblLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(25, 13);
            this.lblLog.TabIndex = 27;
            this.lblLog.Text = "Log";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblMachineConfig
            // 
            this.lblMachineConfig.AutoSize = true;
            this.lblMachineConfig.Location = new System.Drawing.Point(380, 12);
            this.lblMachineConfig.Name = "lblMachineConfig";
            this.lblMachineConfig.Size = new System.Drawing.Size(119, 13);
            this.lblMachineConfig.TabIndex = 28;
            this.lblMachineConfig.Text = "Machine Configuration: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Commands File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLoadCMDFile
            // 
            this.btnLoadCMDFile.Location = new System.Drawing.Point(43, 128);
            this.btnLoadCMDFile.Name = "btnLoadCMDFile";
            this.btnLoadCMDFile.Size = new System.Drawing.Size(22, 19);
            this.btnLoadCMDFile.TabIndex = 30;
            this.btnLoadCMDFile.Text = "...";
            this.btnLoadCMDFile.UseVisualStyleBackColor = true;
            // 
            // txtCommandsFile
            // 
            this.txtCommandsFile.Location = new System.Drawing.Point(72, 129);
            this.txtCommandsFile.Name = "txtCommandsFile";
            this.txtCommandsFile.Size = new System.Drawing.Size(279, 20);
            this.txtCommandsFile.TabIndex = 31;
            // 
            // btnBackConfig
            // 
            this.btnBackConfig.Location = new System.Drawing.Point(383, 264);
            this.btnBackConfig.Name = "btnBackConfig";
            this.btnBackConfig.Size = new System.Drawing.Size(75, 23);
            this.btnBackConfig.TabIndex = 32;
            this.btnBackConfig.Text = "Back";
            this.btnBackConfig.UseVisualStyleBackColor = true;
            this.btnBackConfig.Click += new System.EventHandler(this.btnBackConfig_Click);
            // 
            // btnForwardConfig
            // 
            this.btnForwardConfig.Location = new System.Drawing.Point(528, 264);
            this.btnForwardConfig.Name = "btnForwardConfig";
            this.btnForwardConfig.Size = new System.Drawing.Size(75, 23);
            this.btnForwardConfig.TabIndex = 33;
            this.btnForwardConfig.Text = "Forward";
            this.btnForwardConfig.UseVisualStyleBackColor = true;
            this.btnForwardConfig.Click += new System.EventHandler(this.btnForwardConfig_Click);
            // 
            // picMachineConfig
            // 
            this.picMachineConfig.BackgroundImage = global::VECTool.Properties.Resources.boeingLogo;
            this.picMachineConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMachineConfig.Location = new System.Drawing.Point(383, 35);
            this.picMachineConfig.Margin = new System.Windows.Forms.Padding(2);
            this.picMachineConfig.Name = "picMachineConfig";
            this.picMachineConfig.Size = new System.Drawing.Size(221, 221);
            this.picMachineConfig.TabIndex = 10;
            this.picMachineConfig.TabStop = false;
            // 
            // VECGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 572);
            this.Controls.Add(this.btnForwardConfig);
            this.Controls.Add(this.btnBackConfig);
            this.Controls.Add(this.txtCommandsFile);
            this.Controls.Add(this.btnLoadCMDFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMachineConfig);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.logRTbox);
            this.Controls.Add(this.lblCProf);
            this.Controls.Add(this.lblSTO);
            this.Controls.Add(this.lblSTL);
            this.Controls.Add(this.lblLTO);
            this.Controls.Add(this.lblLTL);
            this.Controls.Add(this.lblShortTool);
            this.Controls.Add(this.lblLongTool);
            this.Controls.Add(this.cboControllerProf);
            this.Controls.Add(this.picMachineConfig);
            this.Controls.Add(this.txtSTO);
            this.Controls.Add(this.txtSTL);
            this.Controls.Add(this.txtLTO);
            this.Controls.Add(this.txtLTL);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtSTMeasureFile);
            this.Controls.Add(this.txtLTMeasureFile);
            this.Controls.Add(this.btnLoadSTMFile);
            this.Controls.Add(this.btnLoadLTMFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VECGUI";
            this.Text = "Boeing Volumetric Error Compensation Tool";
            ((System.ComponentModel.ISupportInitialize)(this.picMachineConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadLTMFile;
        private System.Windows.Forms.Button btnLoadSTMFile;
        private System.Windows.Forms.TextBox txtLTMeasureFile;
        private System.Windows.Forms.TextBox txtSTMeasureFile;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLTL;
        private System.Windows.Forms.TextBox txtLTO;
        private System.Windows.Forms.TextBox txtSTL;
        private System.Windows.Forms.TextBox txtSTO;
        private System.Windows.Forms.PictureBox picMachineConfig;
        private System.Windows.Forms.ComboBox cboControllerProf;
        private System.Windows.Forms.Label lblLongTool;
        private System.Windows.Forms.Label lblShortTool;
        private System.Windows.Forms.Label lblLTL;
        private System.Windows.Forms.Label lblLTO;
        private System.Windows.Forms.Label lblSTL;
        private System.Windows.Forms.Label lblSTO;
        private System.Windows.Forms.Label lblCProf;
        private System.Windows.Forms.RichTextBox logRTbox;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblMachineConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadCMDFile;
        private System.Windows.Forms.TextBox txtCommandsFile;
        private System.Windows.Forms.Button btnBackConfig;
        private System.Windows.Forms.Button btnForwardConfig;
    }
}

