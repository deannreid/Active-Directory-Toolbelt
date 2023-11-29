using Active_Directory_Toolbelt.handlers;
using Active_Directory_Toolbelt.ui.popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Active_Directory_Toolbelt.handlers.LogHandler;

namespace Active_Directory_Toolbelt.ui
{
    public partial class MultiUserTools : MetroFramework.Forms.MetroForm
    {
        public string SelectedApplication { get; private set; }


        public MultiUserTools()
        {
            SelectedApplication = "";
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LogHandler.Log(LogTarget.File, "Button: Return to Menu Pressed");
            //SelectedApplication = "PBD";
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBulkCreate_Click(object sender, EventArgs e)
        {
            LogHandler.Log(LogTarget.File, "Button: Return to Menu Pressed");
            SelectedApplication = "BUCreate";
            btnExecute fileSelect = new btnExecute();
            this.Hide();
            fileSelect.ShowDialog();
            this.Close(); 
        }

        private void btnBulkDelete_Click(object sender, EventArgs e)
        {
            LogHandler.Log(LogTarget.File, "Button: Return to Menu Pressed");
            SelectedApplication = "BUDelete";
            btnExecute fileSelect = new btnExecute();
            this.Hide();
            fileSelect.ShowDialog();
            this.Close();
        }
    }
}
