namespace WinFormsApp1
{
    partial class Details
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
            label1 = new Label();
            drpInputWeightingFactor = new ComboBox();
            numInputs = new NumericUpDown();
            label2 = new Label();
            numOutputs = new NumericUpDown();
            drpOutputWeightingFactor = new ComboBox();
            label3 = new Label();
            numInquiries = new NumericUpDown();
            drpInquiriesWeightingFactor = new ComboBox();
            label4 = new Label();
            numFiles = new NumericUpDown();
            drpFilesWeightingFactor = new ComboBox();
            label5 = new Label();
            numExtenalInterfaces = new NumericUpDown();
            drpExternalInterfacesWeightingFactor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numInputs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOutputs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInquiries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExtenalInterfaces).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 14);
            label1.Name = "label1";
            label1.Size = new Size(227, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of user inputs(number of forms):";
            // 
            // drpInputWeightingFactor
            // 
            drpInputWeightingFactor.DisplayMember = "Text";
            drpInputWeightingFactor.DropDownStyle = ComboBoxStyle.DropDownList;
            drpInputWeightingFactor.FormattingEnabled = true;
            drpInputWeightingFactor.Items.AddRange(new object[] { "3", "4", "6" });
            drpInputWeightingFactor.Location = new Point(396, 14);
            drpInputWeightingFactor.Name = "drpInputWeightingFactor";
            drpInputWeightingFactor.Size = new Size(121, 23);
            drpInputWeightingFactor.TabIndex = 2;
            drpInputWeightingFactor.ValueMember = "Value";
            // 
            // numInputs
            // 
            numInputs.Location = new Point(270, 14);
            numInputs.Name = "numInputs";
            numInputs.Size = new Size(120, 23);
            numInputs.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 43);
            label2.Name = "label2";
            label2.Size = new Size(243, 15);
            label2.TabIndex = 4;
            label2.Text = "Number of user outputs(number of screens):";
            // 
            // numOutputs
            // 
            numOutputs.Location = new Point(270, 44);
            numOutputs.Name = "numOutputs";
            numOutputs.Size = new Size(120, 23);
            numOutputs.TabIndex = 5;
            // 
            // drpOutputWeightingFactor
            // 
            drpOutputWeightingFactor.DisplayMember = "Text";
            drpOutputWeightingFactor.DropDownStyle = ComboBoxStyle.DropDownList;
            drpOutputWeightingFactor.FormattingEnabled = true;
            drpOutputWeightingFactor.Items.AddRange(new object[] { "3", "4", "6" });
            drpOutputWeightingFactor.Location = new Point(396, 43);
            drpOutputWeightingFactor.Name = "drpOutputWeightingFactor";
            drpOutputWeightingFactor.Size = new Size(121, 23);
            drpOutputWeightingFactor.TabIndex = 6;
            drpOutputWeightingFactor.ValueMember = "Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 75);
            label3.Name = "label3";
            label3.Size = new Size(141, 15);
            label3.TabIndex = 7;
            label3.Text = "Number of user inquiries:";
            // 
            // numInquiries
            // 
            numInquiries.Location = new Point(271, 73);
            numInquiries.Name = "numInquiries";
            numInquiries.Size = new Size(120, 23);
            numInquiries.TabIndex = 8;
            // 
            // drpInquiriesWeightingFactor
            // 
            drpInquiriesWeightingFactor.DisplayMember = "Text";
            drpInquiriesWeightingFactor.DropDownStyle = ComboBoxStyle.DropDownList;
            drpInquiriesWeightingFactor.FormattingEnabled = true;
            drpInquiriesWeightingFactor.Items.AddRange(new object[] { "3", "4", "6" });
            drpInquiriesWeightingFactor.Location = new Point(397, 74);
            drpInquiriesWeightingFactor.Name = "drpInquiriesWeightingFactor";
            drpInquiriesWeightingFactor.Size = new Size(121, 23);
            drpInquiriesWeightingFactor.TabIndex = 9;
            drpInquiriesWeightingFactor.ValueMember = "Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 105);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 10;
            label4.Text = "Number of files:";
            // 
            // numFiles
            // 
            numFiles.Location = new Point(271, 105);
            numFiles.Name = "numFiles";
            numFiles.Size = new Size(120, 23);
            numFiles.TabIndex = 11;
            // 
            // drpFilesWeightingFactor
            // 
            drpFilesWeightingFactor.DisplayMember = "Text";
            drpFilesWeightingFactor.DropDownStyle = ComboBoxStyle.DropDownList;
            drpFilesWeightingFactor.FormattingEnabled = true;
            drpFilesWeightingFactor.Items.AddRange(new object[] { "3", "4", "6" });
            drpFilesWeightingFactor.Location = new Point(398, 105);
            drpFilesWeightingFactor.Name = "drpFilesWeightingFactor";
            drpFilesWeightingFactor.Size = new Size(121, 23);
            drpFilesWeightingFactor.TabIndex = 12;
            drpFilesWeightingFactor.ValueMember = "Value";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 134);
            label5.Name = "label5";
            label5.Size = new Size(243, 15);
            label5.TabIndex = 13;
            label5.Text = "Number of extenal interfaces(including DBs):";
            // 
            // numExtenalInterfaces
            // 
            numExtenalInterfaces.Location = new Point(271, 134);
            numExtenalInterfaces.Name = "numExtenalInterfaces";
            numExtenalInterfaces.Size = new Size(120, 23);
            numExtenalInterfaces.TabIndex = 14;
            // 
            // drpExternalInterfacesWeightingFactor
            // 
            drpExternalInterfacesWeightingFactor.DisplayMember = "Text";
            drpExternalInterfacesWeightingFactor.DropDownStyle = ComboBoxStyle.DropDownList;
            drpExternalInterfacesWeightingFactor.FormattingEnabled = true;
            drpExternalInterfacesWeightingFactor.Items.AddRange(new object[] { "3", "4", "6" });
            drpExternalInterfacesWeightingFactor.Location = new Point(399, 134);
            drpExternalInterfacesWeightingFactor.Name = "drpExternalInterfacesWeightingFactor";
            drpExternalInterfacesWeightingFactor.Size = new Size(121, 23);
            drpExternalInterfacesWeightingFactor.TabIndex = 15;
            drpExternalInterfacesWeightingFactor.ValueMember = "Value";
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(drpExternalInterfacesWeightingFactor);
            Controls.Add(numExtenalInterfaces);
            Controls.Add(label5);
            Controls.Add(drpFilesWeightingFactor);
            Controls.Add(numFiles);
            Controls.Add(label4);
            Controls.Add(drpInquiriesWeightingFactor);
            Controls.Add(numInquiries);
            Controls.Add(label3);
            Controls.Add(drpOutputWeightingFactor);
            Controls.Add(numOutputs);
            Controls.Add(label2);
            Controls.Add(numInputs);
            Controls.Add(drpInputWeightingFactor);
            Controls.Add(label1);
            Name = "Details";
            Text = "Details";
            Load += Details_Load;
            ((System.ComponentModel.ISupportInitialize)numInputs).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOutputs).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInquiries).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)numExtenalInterfaces).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox drpInputWeightingFactor;
        private NumericUpDown numInputs;
        private Label label2;
        private NumericUpDown numOutputs;
        private ComboBox drpOutputWeightingFactor;
        private Label label3;
        private NumericUpDown numInquiries;
        private ComboBox drpInquiriesWeightingFactor;
        private Label label4;
        private NumericUpDown numFiles;
        private ComboBox drpFilesWeightingFactor;
        private Label label5;
        private NumericUpDown numExtenalInterfaces;
        private ComboBox drpExternalInterfacesWeightingFactor;
    }
}