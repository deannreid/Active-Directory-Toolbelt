using System.Diagnostics;

namespace Active_Directory_Toolbelt.ui
{
    public partial class CloudTools : MetroFramework.Forms.MetroForm
    {
        public CloudTools()
        {
            InitializeComponent();
        }

        private void BtnAzure_Click(object sender, EventArgs e)
        {
            Process.Start("https://portal.azure.com");
            _ = new CloudTools();
        }

        private void BtnGCP_Click(object sender, EventArgs e)
        {
            Process.Start("https://console.cloud.google.com/");
            _ = new CloudTools();
        }

        private void BtnAWS_Click(object sender, EventArgs e)
        {
            Process.Start("https://aws.amazon.com/console/");
            _ = new CloudTools();
        }

        private void BtnIBM_Click(object sender, EventArgs e)
        {
            Process.Start("https://cloud.ibm.com/login");
            _ = new CloudTools();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            _ = new MainMenu();
        }
    }
}