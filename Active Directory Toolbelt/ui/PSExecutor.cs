using Active_Directory_Toolbelt.handlers;
using System.Diagnostics;
using System.IO;
using static Active_Directory_Toolbelt.handlers.LogHandler;

namespace Active_Directory_Toolbelt.ui
{
    public partial class PSExecutor : MetroFramework.Forms.MetroForm
    {
        public PSExecutor()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // Execute the selected file from the listview
            // If no file is selected then show a message box
            if (lstViewFiles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a file to execute");
            }
            else
            {
                // If a file is selected then execute the file
                // Get the selected file name and extension
                string fileName = lstViewFiles.SelectedItems[0].Text;
                string fileExtension = lstViewFiles.SelectedItems[0].SubItems[1].Text;
                // If the file extension is not .ps1 then show a message box
                if (fileExtension != ".ps1")
                {
                    MessageBox.Show("Please select a powershell script to execute");
                }
                else
                {
                    int errorLevel;

                    // If the file extension is .ps1 then execute the file
                    // Get the path of the file
                    string filePath = lstViewFiles.SelectedItems[0].Text;
                    // Execute the file
                    var startInfo = new ProcessStartInfo()
                    {
                        FileName = "powershell.exe",
                        Arguments = $"-NoProfile -ExecutionPolicy ByPass -redirecterroroutput  -File \"{filePath}\" -NoExit",
                        //Arguments = $"-NoProfile -NoExit -File \"{filePath}\"",
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        UseShellExecute = false
                    };

                    var process = new Process();
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    errorLevel = process.ExitCode;
                    if (errorLevel == 0)
                    {
                        LogHandler.Log(LogTarget.File, "File: " + filePath + " Executed");
                        LogHandler.Log(LogTarget.File, "File: " + filePath + " Output: " + process.StandardOutput.ReadToEnd());
                    }
                    else
                    {
                        LogHandler.Log(LogTarget.File, "File: " + filePath + " Failed to Execute");
                        MessageBox.Show("File: " + filePath + " Failed to Execute");
                        LogHandler.Log(LogTarget.File, "File: " + filePath + " Error: " + process.StandardError.ReadToEnd());
                    }
                }
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            LogHandler.Log(LogTarget.File, "Button: Return to Menu Pressed");
            //SelectedApplication = "PBD";
            var mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            // When button is selected use the following code to open a folder dialog

            // and select the folder that contains the powershell scripts
            // then populate the listview with the files in the folder

            lstViewFiles.Items.Clear();
            var fbd = new FolderBrowserDialog();
            fbd.Description = "Select the folder that contains the powershell scripts";
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                foreach (string file in files)
                {
                    // Show only the name of the file in 1 column and the extension in 2nd column and name them accordingly
                    lstViewFiles.Items.Add(Path.GetFileName(file)).SubItems.Add(Path.GetExtension(file));
                    // show file in a row instead of a box
                    lstViewFiles.View = View.Details;
                    // Rename Column 1 File Name and Column 2 Extension
                    lstViewFiles.Columns[0].Text = "File Name";
                    lstViewFiles.Columns[1].Text = "Extension";
                    //Set Width of the 1st Column to 80% of the listview width
                    lstViewFiles.Columns[0].Width = lstViewFiles.Width * 80 / 100;
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}