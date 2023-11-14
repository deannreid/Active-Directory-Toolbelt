using Active_Directory_Toolbelt.handlers;
using Active_Directory_Toolbelt.utils;
using System.Diagnostics;
using static Active_Directory_Toolbelt.handlers.LogHandler;

/*
 * Active Directory Toolbelt
 * Developed by @ Dean Reid
 *
 * Class Name: AssetTools
 *
 * Class Information:
 *
 * Class handles AssetTools Menu
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
    public partial class AssetTools : MetroFramework.Forms.MetroForm
    {
        public AssetTools()
        {
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

        private void btnSelectID_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS && txtbxAssetID.Text == "SV01337")
            {
                varUserName.Text = "SV01337";
                varSerialNbr.Text = "H5G1337";
                varSysMDL.Text = "Poweredge R550";
                varOSName.Text = "VMWare ESXi";
                varOSVersion.Text = "8.0";

                varBitLockerStatus.Text = "Unlocked";
                varBitLockerStatus.ForeColor = Color.Green;

                varCMPDMN.Text = "XHSTCLOUD";
                varSysIP.Text = "10.0.13.37";
                varDHCPClassD.Text = "XHSTCLOUD.GB";
                varDHCPClassIDBin.Text = "";

                varIsDisabled.Text = "False";
                varIsDisabled.ForeColor = Color.Green;

                btnCompMGMT.Enabled = true;
                btnDiskMGMT.Enabled = true;
                btnNetworkMGMT.Enabled = true;
                btnUserMGMT.Enabled = true;
                btnComputerProp.Enabled = true;
                btnWorkstationDataCap.Enabled = true;
                btnRemotePS.Enabled = true;
                btnRemoteDT.Enabled = true;
                btnRemoteFA.Enabled = true;
                btnDropSCCM.Enabled = true;
                btnKillRPHost.Enabled = true;
                btnForceReboot.Enabled = true;
                btnWorkstationLockdown.Enabled = true;
                btnPing.Enabled = true;
                btnUptime.Enabled = true;
                btnGroupPolicy.Enabled = true;
                btnDiskInfo.Enabled = true;
                btnOfficeRepair.Enabled = true;
                btnHousekeeping.Enabled = true;
                Update();
            }
            else
            {
                // When an ID is entered into the list, connect to Active Directory and get the information for that connected Device
                // Once the information is retrieved, display it in the text boxes
                // Enable the buttons
            }
        }

        //Management Tools
        private void btnCompMGMT_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Unable to open Computer Management on Training Wheels.");
            }
            else
            {
                LogHandler.ErrorLog(LogTarget.File, "Pressed the Comp Management Button");
                // Open ComputerManagement MMC Snap-in for a remote computer using the hostname as txtbxAssetID
                if (string.IsNullOrEmpty(txtbxAssetID.Text))
                {
                    MessageBox.Show("Please enter an asset ID.");
                    return;
                }
                else
                {
                    var process = new Process
                    {
                        StartInfo =
                        {
                            FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\compmgmt.msc"),
                            Arguments = String.Format("/computer={0}", txtbxAssetID.Text)
                        }
                    };
                }
            }
        }

        private void btnDiskMGMT_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Unable to open Disk Management on Training Wheels.");
            }
            else
            {
                // Open DiskManagement MMC Snapin for a remote computer using the hostname as txtbxAssetID
                if (string.IsNullOrEmpty(txtbxAssetID.Text))
                {
                    MessageBox.Show("Please enter an asset ID.");
                    return;
                }
                else
                {
                    var process = new Process
                    {
                        StartInfo =
                        {
                            FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\diskmgmt.msc"),
                            Arguments = String.Format("/computer={0}", txtbxAssetID.Text)
                        }
                    };
                }
            }
        }

        private void btnNetworkMGMT_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Unable to open Network Management on Training Wheels.");
            }
            else
            {
                // Open NetworkManagement MMC Snapin for a remote computer using the hostname as txtbxAssetID
                if (string.IsNullOrEmpty(txtbxAssetID.Text))
                {
                    MessageBox.Show("Please enter an asset ID.");
                    return;
                }
                else
                {
                    var process = new Process
                    {
                        StartInfo =
                        {
                            FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\ncpa.cpl"),
                            Arguments = String.Format("/computer={0}", txtbxAssetID.Text)
                        }
                    };
                }
            }
        }

        private void btnUserMGMT_Click(object sender, EventArgs e)
        {
            // Open UserManagement MMC Snapin for a remote computer using the hostname as txtbxAssetID
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Unable to open User Management on Training Wheels.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtbxAssetID.Text))
                {
                    MessageBox.Show("Please enter an asset ID.");
                    return;
                }
                else
                {
                    var process = new Process
                    {
                        StartInfo =
                        {
                            FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\dsa.msc"),
                            Arguments = String.Format("/server={0}", txtbxAssetID.Text)
                        }
                    };
                }
            }
        }

        private void btnComputerProp_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Unable to open Computer Properties on Training Wheels.");
            }
            else
            {
                //Open Computer Properties MMC Snap-in for a remote computer using the hostname as txtbxAssetID
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\sysdm.cpl"),
                        Arguments = String.Format("/computer={0}", txtbxAssetID.Text)
                    }
                };
            }
        }

        private void btnWorkstationDataCap_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Unable to connect to Workstation on Training Wheels :( .");
            }
            else
            {
                //Open a Remote File Session using the IP as txtbxAssetID
                var process = new Process
                {
                    StartInfo =
                {
                    FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe"),
                    Arguments = String.Format("/v:{0}", txtbxAssetID.Text)
                }
                };
                if (string.IsNullOrEmpty(txtbxAssetID.Text))
                {
                    MessageBox.Show("Please enter an asset ID.");
                    return;
                }
                else
                {
                    process.Start();
                }
            }
        }

        // Remote Control Tools
        private void btnRemotePS_Click(object sender, EventArgs e)
        {
            // Open Powershell and connect to the remote computer using the hostname as txtbxAssetID
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Unable to open Remote Powershell on Training Wheels.");
            }
            else
            {
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = Environment.ExpandEnvironmentVariables(
                            @"%SystemRoot%\system32\WindowsPowerShell\v1.0\powershell.exe"),
                        Arguments = String.Format("/v:{0}", txtbxAssetID.Text)
                    }
                };
                if (string.IsNullOrEmpty(txtbxAssetID.Text))
                {
                    MessageBox.Show("Please enter an asset ID.");
                    return;
                }
                else
                {
                    process.Start();
                }
            }
        }

        private void btnRemoteDT_Click(object sender, EventArgs e)
        {
            //Domain domain = Domain.GetComputerDomain();
            // Get the domain name as a string
            //string domainName = domain.Name;
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Unable to open Remote Desktop on Training Wheels.");
            }
            else
            {
                string domainName = "XHSTCLOUD.CO.UK";
                //Open a Remote Desktop Session using the IP as txtbxAssetID
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe"),
                        Arguments = String.Format("/v:{0}." + domainName, txtbxAssetID.Text)
                    }
                };
                if (string.IsNullOrEmpty(txtbxAssetID.Text))
                {
                    MessageBox.Show("Please enter an asset ID.");
                    return;
                }
                else
                {
                    process.Start();
                }
            }
        }

        private void btnRemoteFA_Click(object sender, EventArgs e)
        {
            // Open an Explorer Process and set the root to the C$ of the IP in txtbxAssetID
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Unable to open Remote File Browser on Training Wheels.");
            }
            else
            {
                string domainName = "XHSTCLOUD.CO.UK";
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\explorer.exe"),
                        Arguments = String.Format("/root \\:{0}." + domainName + "\\c$", txtbxAssetID.Text)
                    }
                };
                if (string.IsNullOrEmpty(txtbxAssetID.Text))
                {
                    MessageBox.Show("Please enter an asset ID.");
                    return;
                }
                else
                {
                    process.Start();
                }
            }
        }

        //DANGER TOOLS
        private void btnDropSCCM_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("SCCM Session Dropped.");
            }
            else
            {
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c ccm.exe -m {txtbxAssetID.Text} -mp 10123 -usepkicert",
                        WindowStyle = ProcessWindowStyle.Hidden
                    }
                };
                if (string.IsNullOrEmpty(txtbxAssetID.Text))
                {
                    MessageBox.Show("Please enter an asset ID.");
                    return;
                }
                else
                {
                    process.Start();
                }
            }
        }

        private void btnKillRPHost_Click(object sender, EventArgs e)
        {
            // Kill the Remote Desktop Host Process on the supplied computer
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("RPHost Session Dropped.");
            }
            else
            {
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c taskkill /s {txtbxAssetID.Text} /im rdpshell.exe /f",
                        WindowStyle = ProcessWindowStyle.Hidden
                    }
                };
                if (string.IsNullOrEmpty(txtbxAssetID.Text))
                {
                    MessageBox.Show("Please enter an asset ID.");
                    return;
                }
                else
                {
                    process.Start();
                }
            }
        }

        private void btnForceReboot_Click(object sender, EventArgs e)
        {
            // Send a shutdown request to a remote computer using powershell
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Remote Restart Request Issued - Sending asset 2 minute warning.");
            }
            else
            {
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = "powershell.exe",
                        Arguments = $"Restart-Computer -ComputerName {txtbxAssetID.Text} -Force",
                        WindowStyle = ProcessWindowStyle.Hidden
                    }
                };
                if (string.IsNullOrEmpty(txtbxAssetID.Text))
                {
                    MessageBox.Show("Please enter an asset ID.");
                    return;
                }
                else
                {
                    process.Start();
                }
            }
        }

        private void btnWorkstationLockdown_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Workstation Lockdown Initiated - You can only Unlock this again from AD Directly.");
                varBitLockerStatus.Text = "Locked";
                varBitLockerStatus.ForeColor = Color.Red;
                varIsDisabled.Text = "True";
                varIsDisabled.ForeColor = Color.Red;
            }
            else
            {
                // Lock a Remote PC by bitlocker
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c manage-bde -lock -computername {txtbxAssetID.Text}",
                        WindowStyle = ProcessWindowStyle.Hidden
                    }
                };
                if (string.IsNullOrEmpty(txtbxAssetID.Text))
                {
                    MessageBox.Show("Please enter an asset ID.");
                    return;
                }
                else
                {
                    process.Start();
                    MessageBox.Show("Workstation Lockdown Initiated - You can only Unlock this again from AD Directly.");
                    varBitLockerStatus.Text = "Locked";
                    varBitLockerStatus.ForeColor = Color.Red;
                    varIsDisabled.Text = "True";
                    varIsDisabled.ForeColor = Color.Red;
                }
            }
        }

        //Other Tools

        private void btnPing_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS)
            {
                var messageLines = new string[]
                {
                    "Pinging 1.1.1.1 with 32 bytes of data:",
                    "Reply from 1.0.13.2: bytes=32 time=2ms TTL=56",
                    "Reply from 1.0.13.2: bytes=32 time=3ms TTL=56",
                    "Reply from 1.0.13.2: bytes=32 time=1ms TTL=56",
                    "Reply from 1.0.13.2: bytes=32 time=3ms TTL=56",
                    "",
                    "Packets: Sent = 4, Received = 4, Lost = 0 (0% loss)",
                    "Minimum = 1ms, Maximum = 3ms, Average = 2ms"
                };
                MessageBox.Show(string.Join(Environment.NewLine, messageLines));
            }
            else
            {
                if (Reference.TRAINING_WHEELS)
                {
                    MessageBox.Show("Asset locked by Bitlocker.");
                }
                else
                {
                    // Lock a Remote PC by bitlocker
                    var process = new Process
                    {
                        StartInfo =
                        {
                            FileName = "cmd.exe",
                            Arguments = $"/c ping {txtbxAssetID.Text}",
                            WindowStyle = ProcessWindowStyle.Hidden
                        }
                    };
                    if (string.IsNullOrEmpty(txtbxAssetID.Text))
                    {
                        MessageBox.Show("Please enter an asset ID.");
                        return;
                    }
                    else
                    {
                        process.Start();
                    }
                }
            }
        }

        private void BtnUptime_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("System Uptime: 1482 Days, 12 Hours, 23 Minutes, 1 Second");
            }
            else
            {
            }
        }

        private void btnGroupPolicy_Click(object sender, EventArgs e)
        {
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Unable to open Group Policy on Training Wheels.");
            }
            else
            {
                // Open Group Policy MMC Snapin on Remote Computer using the hostname typed into txtbxAssetID
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\gpmc.msc"),
                        Arguments = String.Format("/domain={0}", txtbxAssetID.Text)
                    }
                };
            }
        }

        private void btnDiskInfo_Click(object sender, EventArgs e)
        {
            // Read DiskInfo on a remote computer using powershell connecting to the hostname supplied in txtbxAssetID
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Unable to open Disk Info on Training Wheels.");
            }
            else
            {
            }
        }

        private void btnOfficeRepair_Click(object sender, EventArgs e)
        {
            // Start Process to repair a remote Office 365 installation using the hostname typed into txtbxAssetID
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Unable to open Office Repair on Training Wheels.");
            }
            else
            {
            }
        }

        private void btnHousekeeping_Click(object sender, EventArgs e)
        {
            // Command to do some general housekeeping on a remote computer
            if (Reference.TRAINING_WHEELS)
            {
                MessageBox.Show("Unable to open House Keeping on Training Wheels.");
            }
            else
            {
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}