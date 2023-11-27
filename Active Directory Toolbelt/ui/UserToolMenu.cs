using Active_Directory_Toolbelt.handlers;
using Active_Directory_Toolbelt.utils;
using System.DirectoryServices.AccountManagement;
using static Active_Directory_Toolbelt.handlers.LogHandler;

/*
 * Active Directory Toolbelt
 * Developed by @ Dean Reid
 *
 * Class Name: UserToolMenu
 *
 * Class Information:
 *
 * Class handles UserTools Menu
 *
 * Program Version: 1.0
 * Code Version: 1.5
 *
 * Updates:
 * 05/11/2023 - Initial Code Development
 * 10/11/2023 - Added Training Wheels Mode
 */

namespace Active_Directory_Toolbelt.ui
{
    public partial class UserToolMenu : MetroFramework.Forms.MetroForm
    {
        public UserToolMenu()
        {
            InitializeComponent();
            LogHandler.Log(LogTarget.File, "Main Menu Loaded");
            lblDCID.Text = Reference.DOMAIN_ID;
            lblUserID.Text = "Dean R";// Reference.USER_ID;
        }

        private void btnSelectID_Click(object sender, EventArgs e)
        {
            // When user clicks the Select button, the username is checked against the Active Directory to see if it exists
            // If it does, the user is presented with the options to unlock, enable, disable or set the password for the account
            // If it doesn't, the user is presented with a message box stating that the account doesn't exist
            if (Reference.TRAINING_WHEELS && txtbxUserID.Text == "REIDD")
            {
                btnUnlockAcc.Enabled = true;
                btnUnlockAcc.BackColor = Color.Lime;

                btnEnableAcc.Enabled = true;
                btnEnableAcc.BackColor = Color.Lime;

                btnDisableAcc.Enabled = true;
                btnDisableAcc.BackColor = Color.OrangeRed;

                btnSetPasswd.Enabled = true;
                btnSetPasswd.BackColor = Color.DodgerBlue;

                // Enter data from AD (Full Name, SMTP email, Manager, IsLocked, IsDisabled into the relevent text fields
                varUserName.Text = "Dean Reid" + " (" + "REIDD" + ")";
                varUserEmail.Text = "dean.reid@testemail.com";
                varUserManager.Text = "Not Found";
                varIsLocked.Text = "True";
                varIsLocked.ForeColor = Color.Red;
                varIsDisabled.Text = "False";
                varIsDisabled.ForeColor = Color.Green;
                Refresh();
            }
            else
            {
                try
                {
                    using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, Reference.DOMAIN_ID))
                    {
                        UserPrincipal user = UserPrincipal.FindByIdentity(pc, txtbxUserID.Text);
                        if (user != null)
                        {
                            btnUnlockAcc.Enabled = true;
                            btnUnlockAcc.BackColor = Color.Lime;

                            btnEnableAcc.Enabled = true;
                            btnEnableAcc.BackColor = Color.Lime;

                            btnDisableAcc.Enabled = true;
                            btnDisableAcc.BackColor = Color.OrangeRed;

                            btnSetPasswd.Enabled = true;
                            btnSetPasswd.BackColor = Color.DodgerBlue;

                            // Enter data from AD (Full Name, SMTP email, Manager, IsLocked, IsDisabled into the relevant text fields
                            varUserName.Text = user.Name + " (" + user.SamAccountName + ")";
                            varUserEmail.Text = user.EmailAddress;
                            varUserManager.Text = "Not Found";
                            varIsLocked.Text = user.IsAccountLockedOut().ToString();
                            varIsDisabled.Text = user.Enabled.ToString();
                            Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Account does not exist (" + txtbxUserID.Text + ")");
                            LogHandler.ErrorLog(LogTarget.File, "Account does not exist (" + txtbxUserID.Text + ")");
                            varUserName.Text = "User Non Existent (" + txtbxUserID.Text + ")";
                            varUserEmail.Text = "User Non Existent";
                            //varUserManager.Text = user.Manager;
                            varIsLocked.Text = "YES";
                            varIsDisabled.Text = "YES";
                            Refresh();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    LogHandler.ErrorLog(LogTarget.File, ex.Message);
                }
            }
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

        private void btnUnlockAcc_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Account " + txtbxUserID.Text + " Unlocked");
                varIsLocked.Text = "False";
                varIsLocked.ForeColor = Color.Green;
                Refresh();
            }
            else
            {
                // Connect to Active Directory and unlock the account using the username txtbxUserID
                try
                {
                    using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, Reference.DOMAIN_ID))
                    {
                        UserPrincipal user = UserPrincipal.FindByIdentity(pc, txtbxUserID.Text);
                        user.UnlockAccount();
                        MessageBox.Show("Account Unlocked");
                        varIsLocked.Text = "False";
                        varIsLocked.ForeColor = Color.Green;
                        Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    LogHandler.ErrorLog(LogTarget.File, ex.Message);
                }
            }
        }

        private void btnEnableAcc_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Account " + txtbxUserID.Text + " Enabled");
                varIsDisabled.Text = "False";
                varIsDisabled.ForeColor = Color.Green;
                Refresh();
            }
            else
            {
                // Connect to Active Directory and enable the account using the username txtbxUserID
                try
                {
                    using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, Reference.DOMAIN_ID))
                    {
                        UserPrincipal user = UserPrincipal.FindByIdentity(pc, txtbxUserID.Text);
                        user.Enabled = true;
                        user.Save();
                        MessageBox.Show("Account Enabled");
                        varIsDisabled.Text = "False";
                        varIsDisabled.ForeColor = Color.Green;
                        Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    LogHandler.ErrorLog(LogTarget.File, ex.Message);
                }
            }
        }

        private void btnDisableAcc_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Account " + txtbxUserID.Text + " Disabled");
                varIsDisabled.Text = "True";
                varIsDisabled.ForeColor = Color.Red;
                Refresh();
            }
            else
            {
                // Connect to Active Directory and disable the account using the username txtbxUserID
                try
                {
                    using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, Reference.DOMAIN_ID))
                    {
                        UserPrincipal user = UserPrincipal.FindByIdentity(pc, txtbxUserID.Text);
                        user.Enabled = false;
                        user.Save();
                        MessageBox.Show("Account Disabled");
                        varIsDisabled.Text = "True";
                        varIsDisabled.ForeColor = Color.Red;
                        Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    LogHandler.ErrorLog(LogTarget.File, ex.Message);
                }
            }
        }

        private void btnSetPasswd_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS && txtPasswdEntry.Text != "")
            {
                MessageBox.Show("Password Set to: " + txtPasswdEntry.Text);
            }
            else if (txtPasswdEntry.TextLength <= 14)
            {
                MessageBox.Show("Password needs to be more than 15 Characters long ");
            }
            else
            {
                // Connect to Active Directory and set the password entered into txtPasswdEntry for the account using the username txtbxUserID
                try
                {
                    using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, Reference.DOMAIN_ID))
                    {
                        if (txtPasswdEntry.Text != "")
                        {
                            UserPrincipal user = UserPrincipal.FindByIdentity(pc, txtbxUserID.Text);
                            user.SetPassword(txtPasswdEntry.Text);
                            user.Save();
                            MessageBox.Show("Password Set to: " + txtPasswdEntry.Text);
                        }
                        else if (txtPasswdEntry.TextLength <= 14)
                        {
                            MessageBox.Show("Password needs to be more than 15 Characters long ");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    LogHandler.ErrorLog(LogTarget.File, ex.Message);
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlUserInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDCID_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void lblCurrentUser_Click(object sender, EventArgs e)
        {
        }

        private void lblUserID_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}