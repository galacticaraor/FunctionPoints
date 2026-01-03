namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalculateComplexity = new Button();
            btnViewTaskHistory = new Button();
            btnEstimateTime = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnCalculateComplexity
            // 
            btnCalculateComplexity.Location = new Point(222, 61);
            btnCalculateComplexity.Name = "btnCalculateComplexity";
            btnCalculateComplexity.Size = new Size(201, 23);
            btnCalculateComplexity.TabIndex = 0;
            btnCalculateComplexity.Text = "&Calculate Complexity";
            btnCalculateComplexity.UseVisualStyleBackColor = true;
            btnCalculateComplexity.Click += btnCalculateComplexity_Click;
            // 
            // btnViewTaskHistory
            // 
            btnViewTaskHistory.Location = new Point(223, 106);
            btnViewTaskHistory.Name = "btnViewTaskHistory";
            btnViewTaskHistory.Size = new Size(200, 23);
            btnViewTaskHistory.TabIndex = 1;
            btnViewTaskHistory.Text = "&View Task History";
            btnViewTaskHistory.UseVisualStyleBackColor = true;
            btnViewTaskHistory.Click += btnViewTaskHistory_Click;
            // 
            // btnEstimateTime
            // 
            btnEstimateTime.Location = new Point(223, 154);
            btnEstimateTime.Name = "btnEstimateTime";
            btnEstimateTime.Size = new Size(200, 23);
            btnEstimateTime.TabIndex = 2;
            btnEstimateTime.Text = "&Estimate Time";
            btnEstimateTime.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(225, 203);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(198, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnEstimateTime);
            Controls.Add(btnViewTaskHistory);
            Controls.Add(btnCalculateComplexity);
            Name = "MainForm";
            Text = "Project Estimator";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalculateComplexity;
        private Button btnViewTaskHistory;
        private Button btnEstimateTime;
        private Button btnExit;
    }
}
