using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
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
            drpBackup.DataSource = factors;

            drpCommunications.DisplayMember = "Name";
            drpCommunications.ValueMember = "Value";
            drpCommunications.DataSource = factors;

            drpDistributed.DisplayMember = "Name";
            drpDistributed.ValueMember = "Value";
            drpDistributed.DataSource = factors;

            drpPerformance.DisplayMember = "Name";
            drpPerformance.ValueMember = "Value";
            drpPerformance.DataSource = factors;

            drpHeavily.DisplayMember = "Name";
            drpHeavily.ValueMember = "Value";
            drpHeavily.DataSource = factors;

            drpEntry.DisplayMember = "Name";
            drpEntry.ValueMember = "Value";
            drpEntry.DataSource = factors;

            drpMultiple.DisplayMember = "Name";
            drpMultiple.ValueMember = "Value";
            drpMultiple.DataSource = factors;

            drpMaster.DisplayMember = "Name";
            drpMaster.ValueMember = "Value";
            drpMaster.DataSource = factors;

            drpComplex.DisplayMember = "Name";
            drpComplex.ValueMember = "Value";
            drpComplex.DataSource = factors;

            drpInternal.DisplayMember = "Name";
            drpInternal.ValueMember = "Value";
            drpInternal.DataSource = factors;

            drpReusable.DisplayMember = "Name";
            drpReusable.ValueMember = "Value";
            drpReusable.DataSource = factors;

            drpInstallation.DisplayMember = "Name";
            drpInstallation.ValueMember = "Value";
            drpInstallation.DataSource = factors;

            drpOrganizations.DisplayMember = "Name";
            drpOrganizations.ValueMember = "Value";
            drpOrganizations.DataSource = factors;

            drpEase.DisplayMember = "Name";
            drpEase.ValueMember = "Value";
            drpEase.DataSource = factors;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
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
