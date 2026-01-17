using BLL;
using DAL;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Listing : Form
    {
        public Listing()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.BindData();
            mainForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.BindData("", enOperation.Maintenance);
            details.ShowDialog();
        }

        private void Listing_Load(object sender, EventArgs e)
        {
            BindData("");
        }

        public void btnEdit_Click(string id)
        {
            Details details = new Details();
            details.BindData(id, enOperation.Maintenance);
            details.ShowDialog();
        }

        public void btnDelete_Click(string id)
        {
            //If the user confirms they want to delete this record then
            var confirmResult = MessageBox.Show("Are you sure to delete this function point?",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //Initiate an instance of FunctionPointManager using dependency injection
                FunctionPointManager fpm = new FunctionPointManager(new JsonFunctionPointFile(Application.StartupPath + "\\functionpoints.json"));
                Result result = fpm.DeleteFunctionPoint(id);
                //If the call was successful then
                if (result.Successful)
                {
                    MessageBox.Show("Delete successful");
                    BindData("");
                }
                else
                {
                    MessageBox.Show("An error occurred: " + result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void BindData(string keyword)
        {
            string path = Application.StartupPath + "\\functionpoints.json";
            //Initiate an instance of FunctionPointManager using dependency injection
            FunctionPointManager fpm = new FunctionPointManager(new JsonFunctionPointFile(path));
            Result result = fpm.GetFunctionPoints(keyword);
            //If the call was successful then
            if (result.Successful)
            {
                //Get the function point history
                List<FunctionPoint> functionPoints = result.FunctionPoints;
                //Clear the table
                tblFPs.RowStyles.Clear();
                tblFPs.Controls.Clear();
                //Loop through the function points
                foreach (FunctionPoint fp in functionPoints)
                {
                    //Create a new row
                    int rowIndex = tblFPs.RowCount++;
                    tblFPs.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    //Create labels for each column
                    Label lblName = new Label() { Text = fp.Name, AutoSize = true };
                    Label lblComplexity = new Label() { Text = fp.Complexity.ToString(), AutoSize = true };
                    Label lblHours = new Label() { Text = fp.Hours.ToString(), AutoSize = true };
                    Button btnEdit=new Button() { Text = "Edit", AutoSize = true };
                    btnEdit.Click += delegate
                    {
                        btnEdit_Click(fp.ID);
                    };
                    Button btnDelete=new Button() { Text = "Delete", AutoSize = true };
                    btnDelete.Click += delegate
                    {
                        btnDelete_Click(fp.ID);
                    };
                    //Add the labels to the table
                    tblFPs.Controls.Add(lblName, 0, rowIndex);
                    tblFPs.Controls.Add(lblComplexity, 1, rowIndex);
                    tblFPs.Controls.Add(lblHours, 2, rowIndex);
                    tblFPs.Controls.Add(btnEdit, 3, rowIndex);
                    tblFPs.Controls.Add(btnDelete, 4, rowIndex);
                }
            }
            else
            {
                //Display an error message
                MessageBox.Show("An error occurred: " + result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
