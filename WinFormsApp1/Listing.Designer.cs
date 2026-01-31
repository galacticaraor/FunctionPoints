namespace WinFormsApp1
{
    partial class Listing
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
            txtKeyword = new TextBox();
            btnAdd = new Button();
            tblFPs = new TableLayoutPanel();
            btnClose = new Button();
            btnSearch = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 18);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Keyword:";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(117, 17);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(208, 23);
            txtKeyword.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(51, 65);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tblFPs
            // 
            tblFPs.ColumnCount = 5;
            tblFPs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblFPs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblFPs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblFPs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblFPs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblFPs.Location = new Point(54, 112);
            tblFPs.Name = "tblFPs";
            tblFPs.RowCount = 1;
            tblFPs.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblFPs.Size = new Size(709, 160);
            tblFPs.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(55, 294);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(342, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 94);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 93);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 7;
            label3.Text = "Complexity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 93);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Hours";
            // 
            // Listing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(btnClose);
            Controls.Add(tblFPs);
            Controls.Add(btnAdd);
            Controls.Add(txtKeyword);
            Controls.Add(label1);
            Name = "Listing";
            Text = "Listing";
            Load += Listing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKeyword;
        private Button btnAdd;
        private TableLayoutPanel tblFPs;
        private Button btnClose;
        private Button btnSearch;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}