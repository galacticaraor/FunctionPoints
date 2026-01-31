using BLL;
using DAL;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewTaskHistory_Click(object sender, EventArgs e)
        {
            Listing listing = new Listing();
            listing.BindData("");
            listing.ShowDialog();
        }

        private void btnCalculateComplexity_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.BindData("", enOperation.CalculateComplexity);
            details.ShowDialog();
        }

        private void btnEstimateTime_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.BindData("", enOperation.EstimateTime);
            details.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            string path = Application.StartupPath + "\\functionpoints.json";
            //Initiate an instance of FunctionPointManager using dependency injection
            FunctionPointManager fpm = new FunctionPointManager(new JsonFunctionPointFile(path));
            Result result = fpm.GetFunctionPoints("");
            //If the call was successful then
            if (result.Successful)
            {
                //Get the total number of function points
                int totalFPs = result.FunctionPoints.Count;
                //If there are at least 2 then
                if (totalFPs >= 2)
                {
                    //Enable the button for estimating time
                    btnEstimateTime.Enabled = true;
                }
                else
                {
                    //Disable the button for estimating time
                    btnEstimateTime.Enabled = false;
                }
            }
            else
            {
                //Display the error message
                MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
