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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    internal class WeightingFactor
    {
        public string Name { get; set; } = "";
        public int Value { get; set; } = 0;
    }
}
