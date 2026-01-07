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
            label6 = new Label();
            drpBackup = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            drpDistributed = new ComboBox();
            label9 = new Label();
            drpPerformance = new ComboBox();
            label10 = new Label();
            drpHeavily = new ComboBox();
            label11 = new Label();
            drpEntry = new ComboBox();
            label12 = new Label();
            drpMultiple = new ComboBox();
            label13 = new Label();
            drpMaster = new ComboBox();
            label14 = new Label();
            drpComplex = new ComboBox();
            label15 = new Label();
            drpInternal = new ComboBox();
            label16 = new Label();
            drpReusable = new ComboBox();
            label17 = new Label();
            drpInstallation = new ComboBox();
            label18 = new Label();
            drpOrganizations = new ComboBox();
            label19 = new Label();
            drpEase = new ComboBox();
            label20 = new Label();
            txtComplexity = new TextBox();
            label21 = new Label();
            numHours = new NumericUpDown();
            drpCommunications = new ComboBox();
            lblName = new Label();
            txtName = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCalculateComplexity = new Button();
            btnSave = new Button();
            btnEstimateTime = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)numInputs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOutputs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInquiries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExtenalInterfaces).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHours).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 42);
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
            drpInputWeightingFactor.Location = new Point(398, 42);
            drpInputWeightingFactor.Name = "drpInputWeightingFactor";
            drpInputWeightingFactor.Size = new Size(121, 23);
            drpInputWeightingFactor.TabIndex = 2;
            drpInputWeightingFactor.ValueMember = "Value";
            // 
            // numInputs
            // 
            numInputs.Location = new Point(272, 42);
            numInputs.Name = "numInputs";
            numInputs.Size = new Size(120, 23);
            numInputs.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 71);
            label2.Name = "label2";
            label2.Size = new Size(243, 15);
            label2.TabIndex = 4;
            label2.Text = "Number of user outputs(number of screens):";
            // 
            // numOutputs
            // 
            numOutputs.Location = new Point(272, 72);
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
            drpOutputWeightingFactor.Location = new Point(398, 71);
            drpOutputWeightingFactor.Name = "drpOutputWeightingFactor";
            drpOutputWeightingFactor.Size = new Size(121, 23);
            drpOutputWeightingFactor.TabIndex = 6;
            drpOutputWeightingFactor.ValueMember = "Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 103);
            label3.Name = "label3";
            label3.Size = new Size(141, 15);
            label3.TabIndex = 7;
            label3.Text = "Number of user inquiries:";
            // 
            // numInquiries
            // 
            numInquiries.Location = new Point(273, 101);
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
            drpInquiriesWeightingFactor.Location = new Point(399, 102);
            drpInquiriesWeightingFactor.Name = "drpInquiriesWeightingFactor";
            drpInquiriesWeightingFactor.Size = new Size(121, 23);
            drpInquiriesWeightingFactor.TabIndex = 9;
            drpInquiriesWeightingFactor.ValueMember = "Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 133);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 10;
            label4.Text = "Number of files:";
            // 
            // numFiles
            // 
            numFiles.Location = new Point(273, 133);
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
            drpFilesWeightingFactor.Location = new Point(400, 133);
            drpFilesWeightingFactor.Name = "drpFilesWeightingFactor";
            drpFilesWeightingFactor.Size = new Size(121, 23);
            drpFilesWeightingFactor.TabIndex = 12;
            drpFilesWeightingFactor.ValueMember = "Value";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 162);
            label5.Name = "label5";
            label5.Size = new Size(243, 15);
            label5.TabIndex = 13;
            label5.Text = "Number of extenal interfaces(including DBs):";
            // 
            // numExtenalInterfaces
            // 
            numExtenalInterfaces.Location = new Point(273, 162);
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
            drpExternalInterfacesWeightingFactor.Location = new Point(401, 162);
            drpExternalInterfacesWeightingFactor.Name = "drpExternalInterfacesWeightingFactor";
            drpExternalInterfacesWeightingFactor.Size = new Size(121, 23);
            drpExternalInterfacesWeightingFactor.TabIndex = 15;
            drpExternalInterfacesWeightingFactor.ValueMember = "Value";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 213);
            label6.Name = "label6";
            label6.Size = new Size(292, 15);
            label6.TabIndex = 16;
            label6.Text = "Does the system require reliable backup and recovery?";
            // 
            // drpBackup
            // 
            drpBackup.DropDownStyle = ComboBoxStyle.DropDownList;
            drpBackup.FormattingEnabled = true;
            drpBackup.Location = new Point(448, 205);
            drpBackup.Name = "drpBackup";
            drpBackup.Size = new Size(121, 23);
            drpBackup.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 242);
            label7.Name = "label7";
            label7.Size = new Size(196, 15);
            label7.TabIndex = 18;
            label7.Text = "Are data communications required?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 273);
            label8.Name = "label8";
            label8.Size = new Size(233, 15);
            label8.TabIndex = 20;
            label8.Text = "Are there distributed processing functions?";
            // 
            // drpDistributed
            // 
            drpDistributed.DisplayMember = "Text";
            drpDistributed.DropDownStyle = ComboBoxStyle.DropDownList;
            drpDistributed.FormattingEnabled = true;
            drpDistributed.Location = new Point(448, 273);
            drpDistributed.Name = "drpDistributed";
            drpDistributed.Size = new Size(121, 23);
            drpDistributed.TabIndex = 21;
            drpDistributed.ValueMember = "Value";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 303);
            label9.Name = "label9";
            label9.Size = new Size(129, 15);
            label9.TabIndex = 22;
            label9.Text = "Is performance critical?";
            // 
            // drpPerformance
            // 
            drpPerformance.DisplayMember = "Text";
            drpPerformance.DropDownStyle = ComboBoxStyle.DropDownList;
            drpPerformance.FormattingEnabled = true;
            drpPerformance.Items.AddRange(new object[] { "3", "4", "6" });
            drpPerformance.Location = new Point(448, 303);
            drpPerformance.Name = "drpPerformance";
            drpPerformance.Size = new Size(121, 23);
            drpPerformance.TabIndex = 23;
            drpPerformance.ValueMember = "Value";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 333);
            label10.Name = "label10";
            label10.Size = new Size(403, 15);
            label10.TabIndex = 24;
            label10.Text = "Will the system run in an existing, heavily utilized operational envrionment?";
            // 
            // drpHeavily
            // 
            drpHeavily.DisplayMember = "Text";
            drpHeavily.DropDownStyle = ComboBoxStyle.DropDownList;
            drpHeavily.FormattingEnabled = true;
            drpHeavily.Items.AddRange(new object[] { "3", "4", "6" });
            drpHeavily.Location = new Point(448, 333);
            drpHeavily.Name = "drpHeavily";
            drpHeavily.Size = new Size(121, 23);
            drpHeavily.TabIndex = 25;
            drpHeavily.ValueMember = "Value";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 363);
            label11.Name = "label11";
            label11.Size = new Size(235, 15);
            label11.TabIndex = 26;
            label11.Text = "Does the system require on-line data entry?";
            // 
            // drpEntry
            // 
            drpEntry.DisplayMember = "Text";
            drpEntry.DropDownStyle = ComboBoxStyle.DropDownList;
            drpEntry.FormattingEnabled = true;
            drpEntry.Items.AddRange(new object[] { "3", "4", "6" });
            drpEntry.Location = new Point(448, 363);
            drpEntry.Name = "drpEntry";
            drpEntry.Size = new Size(121, 23);
            drpEntry.TabIndex = 27;
            drpEntry.ValueMember = "Value";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 392);
            label12.Name = "label12";
            label12.Size = new Size(357, 15);
            label12.TabIndex = 28;
            label12.Text = "Does the on-line data entry require multiple screens or operations?";
            // 
            // drpMultiple
            // 
            drpMultiple.DisplayMember = "Text";
            drpMultiple.DropDownStyle = ComboBoxStyle.DropDownList;
            drpMultiple.FormattingEnabled = true;
            drpMultiple.Items.AddRange(new object[] { "3", "4", "6" });
            drpMultiple.Location = new Point(448, 392);
            drpMultiple.Name = "drpMultiple";
            drpMultiple.Size = new Size(121, 23);
            drpMultiple.TabIndex = 29;
            drpMultiple.ValueMember = "Value";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 423);
            label13.Name = "label13";
            label13.Size = new Size(159, 15);
            label13.TabIndex = 30;
            label13.Text = "Will there be online updates?";
            // 
            // drpMaster
            // 
            drpMaster.DisplayMember = "Text";
            drpMaster.DropDownStyle = ComboBoxStyle.DropDownList;
            drpMaster.FormattingEnabled = true;
            drpMaster.Items.AddRange(new object[] { "3", "4", "6" });
            drpMaster.Location = new Point(448, 423);
            drpMaster.Name = "drpMaster";
            drpMaster.Size = new Size(121, 23);
            drpMaster.TabIndex = 31;
            drpMaster.ValueMember = "Value";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 456);
            label14.Name = "label14";
            label14.Size = new Size(270, 15);
            label14.TabIndex = 32;
            label14.Text = "Are the inputs, outputs, files or inquiries complex?";
            // 
            // drpComplex
            // 
            drpComplex.DisplayMember = "Text";
            drpComplex.DropDownStyle = ComboBoxStyle.DropDownList;
            drpComplex.FormattingEnabled = true;
            drpComplex.Items.AddRange(new object[] { "3", "4", "6" });
            drpComplex.Location = new Point(448, 456);
            drpComplex.Name = "drpComplex";
            drpComplex.Size = new Size(121, 23);
            drpComplex.TabIndex = 33;
            drpComplex.ValueMember = "Value";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(23, 489);
            label15.Name = "label15";
            label15.Size = new Size(191, 15);
            label15.TabIndex = 34;
            label15.Text = "Is the internal processing complex?";
            // 
            // drpInternal
            // 
            drpInternal.DisplayMember = "Text";
            drpInternal.DropDownStyle = ComboBoxStyle.DropDownList;
            drpInternal.FormattingEnabled = true;
            drpInternal.Items.AddRange(new object[] { "3", "4", "6" });
            drpInternal.Location = new Point(448, 489);
            drpInternal.Name = "drpInternal";
            drpInternal.Size = new Size(121, 23);
            drpInternal.TabIndex = 35;
            drpInternal.ValueMember = "Value";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(23, 521);
            label16.Name = "label16";
            label16.Size = new Size(197, 15);
            label16.TabIndex = 36;
            label16.Text = "Is the code designed to be reusable?";
            // 
            // drpReusable
            // 
            drpReusable.DisplayMember = "Text";
            drpReusable.DropDownStyle = ComboBoxStyle.DropDownList;
            drpReusable.FormattingEnabled = true;
            drpReusable.Items.AddRange(new object[] { "3", "4", "6" });
            drpReusable.Location = new Point(448, 521);
            drpReusable.Name = "drpReusable";
            drpReusable.Size = new Size(121, 23);
            drpReusable.TabIndex = 37;
            drpReusable.ValueMember = "Value";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(23, 557);
            label17.Name = "label17";
            label17.Size = new Size(224, 15);
            label17.TabIndex = 38;
            label17.Text = "Are conversion and installation included?";
            // 
            // drpInstallation
            // 
            drpInstallation.DisplayMember = "Text";
            drpInstallation.DropDownStyle = ComboBoxStyle.DropDownList;
            drpInstallation.FormattingEnabled = true;
            drpInstallation.Items.AddRange(new object[] { "3", "4", "6" });
            drpInstallation.Location = new Point(448, 557);
            drpInstallation.Name = "drpInstallation";
            drpInstallation.Size = new Size(121, 23);
            drpInstallation.TabIndex = 39;
            drpInstallation.ValueMember = "Value";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(24, 589);
            label18.Name = "label18";
            label18.Size = new Size(271, 15);
            label18.TabIndex = 40;
            label18.Text = "Is the system designed for different organizations?";
            // 
            // drpOrganizations
            // 
            drpOrganizations.DisplayMember = "Text";
            drpOrganizations.DropDownStyle = ComboBoxStyle.DropDownList;
            drpOrganizations.FormattingEnabled = true;
            drpOrganizations.Items.AddRange(new object[] { "3", "4", "6" });
            drpOrganizations.Location = new Point(448, 589);
            drpOrganizations.Name = "drpOrganizations";
            drpOrganizations.Size = new Size(121, 23);
            drpOrganizations.TabIndex = 41;
            drpOrganizations.ValueMember = "Value";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(24, 623);
            label19.Name = "label19";
            label19.Size = new Size(337, 15);
            label19.TabIndex = 42;
            label19.Text = "Is the application designed to facilitate ease of use by the user?";
            // 
            // drpEase
            // 
            drpEase.DisplayMember = "Text";
            drpEase.DropDownStyle = ComboBoxStyle.DropDownList;
            drpEase.FormattingEnabled = true;
            drpEase.Items.AddRange(new object[] { "3", "4", "6" });
            drpEase.Location = new Point(448, 623);
            drpEase.Name = "drpEase";
            drpEase.Size = new Size(121, 23);
            drpEase.TabIndex = 43;
            drpEase.ValueMember = "Value";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(24, 662);
            label20.Name = "label20";
            label20.Size = new Size(70, 15);
            label20.TabIndex = 45;
            label20.Text = "Complexity:";
            // 
            // txtComplexity
            // 
            txtComplexity.Location = new Point(452, 659);
            txtComplexity.Name = "txtComplexity";
            txtComplexity.ReadOnly = true;
            txtComplexity.Size = new Size(100, 23);
            txtComplexity.TabIndex = 46;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(24, 696);
            label21.Name = "label21";
            label21.Size = new Size(101, 15);
            label21.TabIndex = 47;
            label21.Text = "Number of hours:";
            // 
            // numHours
            // 
            numHours.DecimalPlaces = 2;
            numHours.Location = new Point(449, 696);
            numHours.Name = "numHours";
            numHours.Size = new Size(120, 23);
            numHours.TabIndex = 48;
            // 
            // drpCommunications
            // 
            drpCommunications.DropDownStyle = ComboBoxStyle.DropDownList;
            drpCommunications.FormattingEnabled = true;
            drpCommunications.Location = new Point(449, 240);
            drpCommunications.Name = "drpCommunications";
            drpCommunications.Size = new Size(121, 23);
            drpCommunications.TabIndex = 52;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(21, 13);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 53;
            lblName.Text = "Name:";
            lblName.Click += label22_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(271, 11);
            txtName.Name = "txtName";
            txtName.Size = new Size(249, 23);
            txtName.TabIndex = 54;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCalculateComplexity);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnEstimateTime);
            flowLayoutPanel1.Controls.Add(btnClose);
            flowLayoutPanel1.Location = new Point(28, 735);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(539, 39);
            flowLayoutPanel1.TabIndex = 55;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btnCalculateComplexity
            // 
            btnCalculateComplexity.Location = new Point(3, 3);
            btnCalculateComplexity.Name = "btnCalculateComplexity";
            btnCalculateComplexity.Size = new Size(144, 23);
            btnCalculateComplexity.TabIndex = 45;
            btnCalculateComplexity.Text = "&Calculate Complexity";
            btnCalculateComplexity.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(153, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 51;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEstimateTime
            // 
            btnEstimateTime.Location = new Point(234, 3);
            btnEstimateTime.Name = "btnEstimateTime";
            btnEstimateTime.Size = new Size(123, 23);
            btnEstimateTime.TabIndex = 52;
            btnEstimateTime.Text = "&Estimate Time";
            btnEstimateTime.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(363, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 53;
            btnClose.Text = "C&lose";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 817);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(drpCommunications);
            Controls.Add(numHours);
            Controls.Add(label21);
            Controls.Add(txtComplexity);
            Controls.Add(label20);
            Controls.Add(drpEase);
            Controls.Add(label19);
            Controls.Add(drpOrganizations);
            Controls.Add(label18);
            Controls.Add(drpInstallation);
            Controls.Add(label17);
            Controls.Add(drpReusable);
            Controls.Add(label16);
            Controls.Add(drpInternal);
            Controls.Add(label15);
            Controls.Add(drpComplex);
            Controls.Add(label14);
            Controls.Add(drpMaster);
            Controls.Add(label13);
            Controls.Add(drpMultiple);
            Controls.Add(label12);
            Controls.Add(drpEntry);
            Controls.Add(label11);
            Controls.Add(drpHeavily);
            Controls.Add(label10);
            Controls.Add(drpPerformance);
            Controls.Add(label9);
            Controls.Add(drpDistributed);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(drpBackup);
            Controls.Add(label6);
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
            ((System.ComponentModel.ISupportInitialize)numHours).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
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
        private Label label6;
        private ComboBox drpBackup;
        private Label label7;
        private Label label8;
        private ComboBox drpDistributed;
        private Label label9;
        private ComboBox drpPerformance;
        private Label label10;
        private ComboBox drpHeavily;
        private Label label11;
        private ComboBox drpEntry;
        private Label label12;
        private ComboBox drpMultiple;
        private Label label13;
        private ComboBox drpMaster;
        private Label label14;
        private ComboBox drpComplex;
        private Label label15;
        private ComboBox drpInternal;
        private Label label16;
        private ComboBox drpReusable;
        private Label label17;
        private ComboBox drpInstallation;
        private Label label18;
        private ComboBox drpOrganizations;
        private Label label19;
        private ComboBox drpEase;
        private Label label20;
        private TextBox txtComplexity;
        private Label label21;
        private NumericUpDown numHours;
        private ComboBox drpCommunications;
        private Label lblName;
        private TextBox txtName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCalculateComplexity;
        private Button btnSave;
        private Button btnEstimateTime;
        private Button btnClose;
    }
}