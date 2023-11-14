using Active_Directory_Toolbelt.handlers;
using static Active_Directory_Toolbelt.handlers.LogHandler;

namespace Active_Directory_Toolbelt.ui
{
    public partial class AdminFailedLogin : MetroFramework.Forms.MetroForm
    {
        public AdminFailedLogin()
        {
            InitializeComponent();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            LogHandler.Log(LogTarget.File, "Button: Return to Menu Pressed");
            var mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }
    }
}