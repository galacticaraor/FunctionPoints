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
            listing.ShowDialog();
        }

        private void btnCalculateComplexity_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.ShowDialog();
        }

        private void btnEstimateTime_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.ShowDialog();
        }
    }
}
