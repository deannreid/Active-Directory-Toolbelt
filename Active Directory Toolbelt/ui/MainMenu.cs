using Active_Directory_Toolbelt.handlers;
using Active_Directory_Toolbelt.utils;
using static Active_Directory_Toolbelt.handlers.LogHandler;

namespace Active_Directory_Toolbelt.ui
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
            LogHandler.Log(LogTarget.File, "Main Menu Loaded");
            lblDCID.Text = Reference.DOMAIN_ID;
            lblUserID.Text = Reference.USER_ID;
        }

        private void BtnUserTools_Click(object sender, EventArgs e)
        {
            LogHandler.Log(LogTarget.File, "Button: User Tools Pressed");
            var userToolMenu = new UserToolMenu();
            this.Hide();
            userToolMenu.ShowDialog();
            this.Close();
        }

        private void BtnAssetTools_Click(object sender, EventArgs e)
        {
            LogHandler.Log(LogTarget.File, "Button: Asset Tools Pressed");
            var assetTools = new AssetTools();
            this.Hide();
            assetTools.ShowDialog();
            this.Close();
        }

        private void BtnCloudTools_Click(object sender, EventArgs e)
        {
            LogHandler.Log(LogTarget.File, "Button: Cloud Tools Pressed");
            var cloudtools = new CloudTools();
            this.Hide();
            cloudtools.ShowDialog();
            this.Close();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            LogHandler.Log(LogTarget.File, "Button: Admin Tools Pressed");
            var sp = new AdminFailedLogin();
            this.Hide();
            sp.ShowDialog();
            this.Close();
        }

        private void BtnPSExec_Click(object sender, EventArgs e)
        {
            LogHandler.Log(LogTarget.File, "Button: PS Exec Pressed");
            var psExecutor = new PSExecutor();
            this.Hide();
            psExecutor.ShowDialog();
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}