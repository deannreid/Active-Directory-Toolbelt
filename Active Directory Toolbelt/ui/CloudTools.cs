using Active_Directory_Toolbelt.ui.popup;
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

            varIsDisabled.Text = "Waiting for SSO Prompt";
            varIsDisabled.ForeColor = Color.Orange;

            var azureLogin = new CloudLoginPopup();
            azureLogin.ShowDialog();
            
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