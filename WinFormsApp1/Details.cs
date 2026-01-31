using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WinFormsApp1
{
    public partial class Details : Form
    {
        public string ID { get; set; } = "";
        public Details()
        {
            InitializeComponent();
        }

        public void LoadForm()
        {

        }

        private void Details_Load(object sender, EventArgs e)
        {
            drpInputWeightingFactor.DisplayMember = "Name";
            drpInputWeightingFactor.ValueMember = "Value";
            drpInputWeightingFactor.DataSource = new WeightingFactor[] {
                new WeightingFactor { Name = "Simple", Value = 3 },
                new WeightingFactor { Name = "Average", Value = 4 },
                new WeightingFactor { Name = "Complex", Value = 6 }
            };
            drpOutputWeightingFactor.DisplayMember = "Name";
            drpOutputWeightingFactor.ValueMember = "Value";
            drpOutputWeightingFactor.DataSource = new WeightingFactor[] {
                new WeightingFactor { Name = "Simple", Value = 4 },
                new WeightingFactor { Name = "Average", Value = 5 },
                new WeightingFactor { Name = "Complex", Value = 7 }
            };
            drpInquiriesWeightingFactor.DisplayMember = "Name";
            drpInquiriesWeightingFactor.ValueMember = "Value";
            drpInquiriesWeightingFactor.DataSource = new WeightingFactor[] {
                new WeightingFactor { Name = "Simple", Value = 3 },
                new WeightingFactor { Name = "Average", Value = 4 },
                new WeightingFactor { Name = "Complex", Value = 6 }
            };
            drpFilesWeightingFactor.DisplayMember = "Name";
            drpFilesWeightingFactor.ValueMember = "Value";
            drpFilesWeightingFactor.DataSource = new WeightingFactor[] {
                new WeightingFactor { Name = "Simple", Value = 7 },
                new WeightingFactor { Name = "Average", Value = 10 },
                new WeightingFactor { Name = "Complex", Value = 15 }
            };
            drpExternalInterfacesWeightingFactor.DisplayMember = "Name";
            drpExternalInterfacesWeightingFactor.ValueMember = "Value";
            drpExternalInterfacesWeightingFactor.DataSource = new WeightingFactor[] {
                new WeightingFactor { Name = "Simple", Value = 5 },
                new WeightingFactor { Name = "Average", Value = 7 },
                new WeightingFactor { Name = "Complex", Value = 10 }
            };

            Factor[] factors = new Factor[]
            {
                new Factor { Name = "No influence", Value = 0 },
                new Factor { Name = "Incidental", Value = 1 },
                new Factor { Name = "Moderate", Value = 2 },
                new Factor { Name = "Average", Value = 3 },
                new Factor { Name = "Significant", Value = 4 },
                new Factor { Name = "Essential", Value = 5 }
            };
            drpBackup.DisplayMember = "Name";
            drpBackup.ValueMember = "Value";
            drpBackup.DataSource = new BindingSource(factors, null);

            drpCommunications.DisplayMember = "Name";
            drpCommunications.ValueMember = "Value";
            drpCommunications.DataSource = new BindingSource(factors, null);

            drpDistributed.DisplayMember = "Name";
            drpDistributed.ValueMember = "Value";
            drpDistributed.DataSource = new BindingSource(factors, null);

            drpPerformance.DisplayMember = "Name";
            drpPerformance.ValueMember = "Value";
            drpPerformance.DataSource = new BindingSource(factors, null);

            drpHeavily.DisplayMember = "Name";
            drpHeavily.ValueMember = "Value";
            drpHeavily.DataSource = new BindingSource(factors, null);

            drpEntry.DisplayMember = "Name";
            drpEntry.ValueMember = "Value";
            drpEntry.DataSource = new BindingSource(factors, null);

            drpMultiple.DisplayMember = "Name";
            drpMultiple.ValueMember = "Value";
            drpMultiple.DataSource = new BindingSource(factors, null);

            drpMaster.DisplayMember = "Name";
            drpMaster.ValueMember = "Value";
            drpMaster.DataSource = new BindingSource(factors, null);

            drpComplex.DisplayMember = "Name";
            drpComplex.ValueMember = "Value";
            drpComplex.DataSource = new BindingSource(factors, null);

            drpInternal.DisplayMember = "Name";
            drpInternal.ValueMember = "Value";
            drpInternal.DataSource = new BindingSource(factors, null);

            drpReusable.DisplayMember = "Name";
            drpReusable.ValueMember = "Value";
            drpReusable.DataSource = new BindingSource(factors, null);

            drpInstallation.DisplayMember = "Name";
            drpInstallation.ValueMember = "Value";
            drpInstallation.DataSource = new BindingSource(factors, null);

            drpOrganizations.DisplayMember = "Name";
            drpOrganizations.ValueMember = "Value";
            drpOrganizations.DataSource = new BindingSource(factors, null);

            drpEase.DisplayMember = "Name";
            drpEase.ValueMember = "Value";
            drpEase.DataSource = new BindingSource(factors, null);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //If the name textbox is not filled in then
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Name is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FunctionPoint fp = AssignDataToObject();
            //Initiate an instance of FunctionPointManager using dependency injection
            FunctionPointManager FunctionPointManager = new FunctionPointManager(new JsonFunctionPointFile(AppDomain.CurrentDomain.BaseDirectory + "\\FunctionPoints.json"));
            double complexity = FunctionPointManager.CalculateComplexity(fp);
            fp.Complexity = complexity;
            Result result = new Result();
            //If the user is adding then
            if (ID == "")
            {
                result = FunctionPointManager.AddFunctionPoint(fp);
            }
            else
            {
                result = FunctionPointManager.EditFunctionPoint(fp);
            }
            //If the call was successful then
            if (result.Successful)
            {
                MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listing listing = (Listing)Application.OpenForms["Listing"];
                listing.BindData("");
                Close();
            }
            else
            {
                MessageBox.Show("An error occurred: " + result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BindData(string id, enOperation operation)
        {
            //Assign the ID property for use later when determining whether the user is adding or editing
            ID = id;
            FunctionPoint fp = new FunctionPoint("");
            switch (operation)
            {
                case enOperation.Maintenance:
                    //If the user is retrieving a function point record then
                    if (ID != "")
                    {
                        FunctionPointManager FunctionPointManager = new FunctionPointManager(new JsonFunctionPointFile(AppDomain.CurrentDomain.BaseDirectory + "\\FunctionPoints.json"));
                        Result result = FunctionPointManager.GetFunctionPoint(id);
                        if (!result.Successful)
                        {
                            //Inform the user about the error
                            MessageBox.Show("An error occurred: " + result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //Get the function point record
                        fp = result.FunctionPoints[0];
                    }
                    //Display the name controls
                    lblName.Visible = true;
                    txtName.Visible = true;
                    //Hide the calculate and estimate controls
                    btnCalculateComplexity.Visible = false;
                    btnEstimateTime.Visible = false;
                    //Display the save button
                    btnSave.Visible = true;
                    break;
                case enOperation.CalculateComplexity:
                    //Hide the name controls
                    lblName.Visible = false;
                    txtName.Visible = false;
                    //Display the calculate button
                    btnCalculateComplexity.Visible = true;
                    //Hide the estimate button
                    btnEstimateTime.Visible = false;
                    //Hide the hours controls
                    lblHours.Visible = false;
                    numHours.Visible = false;
                    //Hide the save button
                    btnSave.Visible = false;
                    break;
                case enOperation.EstimateTime:
                    //Hide the name controls
                    lblName.Visible = false;
                    txtName.Visible = false;
                    //Hide the calculate controls
                    lblComplexity.Visible = false;
                    txtComplexity.Visible = false;
                    btnCalculateComplexity.Visible = false;
                    //Display the estimate controls
                    btnEstimateTime.Visible = true;
                    //Hide the save button
                    btnSave.Visible = false;
                    break;
            }
            //Bind the data from the record to the controls
            txtName.Text = fp.Name;
            numInputs.Value = fp.NumInputs;
            drpInputWeightingFactor.SelectedValue = fp.InputsWeightingFactor;
            numOutputs.Value = fp.NumOutputs;
            drpOutputWeightingFactor.SelectedValue = fp.OutputsWeightingFactor;
            numInquiries.Value = fp.NumProcesses;
            drpInquiriesWeightingFactor.SelectedValue = fp.ProcessesWeightingFactor;
            numFiles.Value = fp.NumFiles;
            drpFilesWeightingFactor.SelectedValue = fp.FilesWeightingFactor;
            numExtenalInterfaces.Value = fp.NumExternals;
            drpExternalInterfacesWeightingFactor.SelectedValue = fp.ExternalsWeightingFactor;
            drpBackup.SelectedValue = fp.Backup;
            drpCommunications.SelectedValue = fp.Communications;
            drpDistributed.SelectedValue = fp.Distributed;
            drpPerformance.SelectedValue = fp.Performance;
            drpHeavily.SelectedValue = fp.Heavily;
            drpEntry.SelectedValue = fp.Entry;
            drpMultiple.SelectedValue = fp.Multiple;
            drpMaster.SelectedValue = fp.Master;
            drpComplex.SelectedValue = fp.Complex;
            drpInternal.SelectedValue = fp.Internal;
            drpReusable.SelectedValue = fp.Reusable;
            drpInstallation.SelectedValue = fp.Installation;
            drpOrganizations.SelectedValue = fp.Organizations;
            drpEase.SelectedValue = fp.Ease;
            txtComplexity.Text = fp.Complexity.ToString("F2");
            numHours.Value = (decimal)fp.Hours;
        }

        private void btnCalculateComplexity_Click(object sender, EventArgs e)
        {
            FunctionPoint fp = AssignDataToObject();
            //Initiate an instance of FunctionPointManager using dependency injection
            FunctionPointManager FunctionPointManager = new FunctionPointManager(new JsonFunctionPointFile(AppDomain.CurrentDomain.BaseDirectory + "\\FunctionPoints.json"));
            double complexity = FunctionPointManager.CalculateComplexity(fp);
            //Bind the complexity to the label on the form
            txtComplexity.Text = complexity.ToString("F2");
        }

        private void btnEstimateTime_Click(object sender, EventArgs e)
        {
            FunctionPoint fp = AssignDataToObject();
            //Initiate an instance of FunctionPointManager using dependency injection
            FunctionPointManager FunctionPointManager = new FunctionPointManager(new JsonFunctionPointFile(AppDomain.CurrentDomain.BaseDirectory + "\\FunctionPoints.json"));
            double complexity = FunctionPointManager.CalculateComplexity(fp);
            fp.Complexity = complexity;
            double hours = FunctionPointManager.EstimateTime(fp);
            //Bind the hours to the textbox on the form
            numHours.Value = (decimal)hours;
        }

        private FunctionPoint AssignDataToObject()
        {
            string id = ID;
            //If the user is adding then
            if (id == "")
            {
                id = Guid.NewGuid().ToString();
            }
            //Create a new instance of FunctionPoint with the ID in the constructor
            FunctionPoint fp = new FunctionPoint(id)
            {
                Name = txtName.Text.Trim(),
                NumInputs = (int)numInputs.Value,
                InputsWeightingFactor = (int)drpInputWeightingFactor.SelectedValue,
                NumOutputs = (int)numOutputs.Value,
                OutputsWeightingFactor = (int)drpOutputWeightingFactor.SelectedValue,
                NumProcesses = (int)numInquiries.Value,
                ProcessesWeightingFactor = (int)drpInquiriesWeightingFactor.SelectedValue,
                NumFiles = (int)numFiles.Value,
                FilesWeightingFactor = (int)drpFilesWeightingFactor.SelectedValue,
                NumExternals = (int)numExtenalInterfaces.Value,
                ExternalsWeightingFactor = (int)drpExternalInterfacesWeightingFactor.SelectedValue,
                Backup = (int)drpBackup.SelectedValue,
                Communications = (int)drpCommunications.SelectedValue,
                Distributed = (int)drpDistributed.SelectedValue,
                Performance = (int)drpPerformance.SelectedValue,
                Heavily = (int)drpHeavily.SelectedValue,
                Entry = (int)drpEntry.SelectedValue,
                Multiple = (int)drpMultiple.SelectedValue,
                Master = (int)drpMaster.SelectedValue,
                Complex = (int)drpComplex.SelectedValue,
                Internal = (int)drpInternal.SelectedValue,
                Reusable = (int)drpReusable.SelectedValue,
                Installation = (int)drpInstallation.SelectedValue,
                Organizations = (int)drpOrganizations.SelectedValue,
                Ease = (int)drpEase.SelectedValue,
                Complexity = double.Parse(txtComplexity.Text),
                Hours = (double)numHours.Value
            };
            return fp;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            mainForm.BindData();
            Close();
        }
    }


    internal class WeightingFactor
    {
        public string Name { get; set; } = "";
        public int Value { get; set; } = 0;
    }
    internal class Factor
    {
        public string Name { get; set; } = "";
        public int Value { get; set; } = 0;
    }
}
