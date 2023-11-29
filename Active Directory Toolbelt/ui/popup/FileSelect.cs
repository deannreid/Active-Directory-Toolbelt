using Active_Directory_Toolbelt.handlers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Active_Directory_Toolbelt.handlers.LogHandler;

namespace Active_Directory_Toolbelt.ui.popup
{
    public partial class btnExecute : MetroFramework.Forms.MetroForm
    {
        // private string nameDataC1 = "";
        // private string isEnabledDataC2 = "";
        // private string passwordDataC3 = "";
        // private string groupDataC4 = "";
        // private string cyberAccessDataC5 = "";
        private string azureApiUrl = "https://api.azure.com/your-endpoint";
        private string cyberarkApiUrl = "https://api.cyberark.com/your-endpoint";
        public btnExecute()
        {
            InitializeComponent();
            lstViewFiles.Hide();
            this.ClientSize = new Size(264, 289);

        }

        private void btnCSVSel_Click(object sender, EventArgs e)
        {
            lstViewFiles.Items.Clear();
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select CSV File";
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.Multiselect = false; // Set to false if you only want to select one file

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.ClientSize = new Size(963, 523);
                lstViewFiles.Show();

                foreach (string filePath in openFileDialog.FileNames)
                {
                    lblSelectedFiles.Text = (Path.GetFileName(filePath));
                    lstViewFiles.Columns[0].Text = "Name";
                    lstViewFiles.Columns[1].Text = "UPN";
                    lstViewFiles.Columns[2].Text = "Password";
                    lstViewFiles.Columns[3].Text = "Group(s)";
                    lstViewFiles.Columns[4].Text = "isEnabled";
                    lstViewFiles.Columns[5].Text = "CyberArk Access";

                    lstViewFiles.View = View.Details;
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        if (lines.Length > 0)
                        {
                            /*// Split the first line to get headers
                            string[] headers = lines[0].Split(',');

                            // Add headers to the ListView
                            foreach (var header in headers)
                            {
                                lstViewFiles.Columns.Add(header, -2, HorizontalAlignment.Left);
                            }*/

                            // Populate the ListView with data
                            for (int i = 1; i < lines.Length; i++)
                            {
                                string[] data = lines[i].Split(',');
                                ListViewItem item = new ListViewItem(data);
                                lstViewFiles.Items.Add(item);
                            }
                        }

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Another user is already using this file.");
                    }
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Assuming you have a ListView named myListView
            ListView.ListViewItemCollection items = lstViewFiles.Items;

            // Start the loop from index 1 to skip the first row
            for (int i = 1; i < items.Count; i++)
            {
                ListViewItem item = items[i];

                string azureApiUrl = "";
                string nameDataC0 = item.SubItems[0].Text;
                string upnDataC1 = item.SubItems[1].Text;
                string passwordDataC2 = item.SubItems[2].Text;
                string groupDataC3 = item.SubItems[3].Text;
                string isEnabledDataC4 = item.SubItems[4].Text;
                string cyberAccessDataC5 = item.SubItems[5].Text;

                // Print the data (replace this with Azure and CyberArk integration)
                Console.WriteLine
                    (
                        $"Column 0: {nameDataC0}, " +
                        $"Column 1: {upnDataC1}" +
                        $"Column 2: {passwordDataC2}" +
                        $"Column 3: {groupDataC3}" +
                        $"Column 4: {isEnabledDataC4}" +
                        $"Column 4: {cyberAccessDataC5}"
                     );

                _ = CreateAzureAccount(azureApiUrl, nameDataC0, upnDataC1, passwordDataC2, groupDataC3, isEnabledDataC4);

                if (cyberAccessDataC5 == "true")
                {
                    _ = CreateCyberArkAccount(nameDataC0, upnDataC1, passwordDataC2, groupDataC3, isEnabledDataC4);
                }
            }
        }

        // Create Azure Method
        private async Task CreateAzureAccount(string azureApiUrl, string nameDataC0, string upnDataC1, string passwordDataC2, string groupDataC3, string isEnabledDataC4)
        {
            // Placeholder code for demonstration purposes
            Console.WriteLine($"Creating Azure account with data: {nameDataC0}, {upnDataC1}, {passwordDataC2}, {groupDataC3}, {isEnabledDataC4}");
            MessageBox.Show($"Creating Azure account with data:\nName: {nameDataC0},\nUPN:{upnDataC1},\nPaswd:{passwordDataC2},\nGroups:{groupDataC3},\nAccount Enabled:{isEnabledDataC4}");

            System.Windows.Forms.ListView.ListViewItemCollection items = lstViewFiles.Items;
            for (int i = 1; i < items.Count; i++)
            {
                System.Windows.Forms.ListViewItem item = items[i];

                string nameDataC00 = item.SubItems[0].Text;
                string upnDataC11 = item.SubItems[1].Text;
                string passwordDataC22 = item.SubItems[2].Text;
                string groupDataC33 = item.SubItems[3].Text;
                string isEnabledDataC44 = item.SubItems[4].Text;
                string cyberAccessDataC55 = item.SubItems[5].Text;
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    foreach (UserInformation user in lstViewFiles.Items)
                    {
                        var data = new { name = user.nameDataC0, upn = user.upnDataC1, password = user.passwordDataC2, groups = user.groupDataC3, isEnabled = user.isEnabledDataC4, cyberarkAccess = user.cyberAccessDataC5 };
                        string json = JsonConvert.SerializeObject(data);

                        var response = await httpClient.PostAsync(azureApiUrl, new StringContent(json));
                        if (response.IsSuccessStatusCode)
                        {
                            Console.WriteLine("Azure API call successful for user: " + user.nameDataC0 + "with MiM/RACFID of " + user.upnDataC1);
                            // Insert Code
                        }
                        else
                        {
                            Console.WriteLine("Azure API call successful for user: " + user.nameDataC0 + "with MiM/RACFID of " + user.upnDataC1);
                            // Insert Code
                        }
                    }
                }
            }
        }

        private async Task CreateCyberArkAccount(string nameDataC0, string upnDataC1, string passwordDataC2, string groupDataC3, string isEnabledDataC4)
        {
            // Placeholder code for demonstration purposes
            string nameDataC0_CA = nameDataC0 + "_t2";
            Console.WriteLine($"Creating CyberArk account with data: {nameDataC0_CA}, {upnDataC1}, {passwordDataC2}, {groupDataC3}, {isEnabledDataC4}");
            LogHandler.Log(LogTarget.File, $"Creating CyberArk account with data: {nameDataC0_CA}, {upnDataC1}, {passwordDataC2}, {groupDataC3}, {isEnabledDataC4}");
            MessageBox.Show($"Creating CyberArk account with data:\n Name: {nameDataC0_CA},\nUPN:{upnDataC1},\nPaswd:{passwordDataC2},\nGroups:{groupDataC3},\nAccount Enabled:{isEnabledDataC4}");

            System.Windows.Forms.ListView.ListViewItemCollection items = lstViewFiles.Items;
            for (int i = 1; i < items.Count; i++)
            {
                System.Windows.Forms.ListViewItem item = items[i];

                string nameDataC00 = item.SubItems[0].Text;
                string upnDataC11 = item.SubItems[1].Text;
                string passwordDataC22 = item.SubItems[2].Text;
                string groupDataC33 = item.SubItems[3].Text;
                string isEnabledDataC44 = item.SubItems[4].Text;
                string cyberAccessDataC55 = item.SubItems[5].Text;
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "YourCyberArkAccessToken");

                    foreach (UserInformation user in lstViewFiles.Items)
                    {
                        var data = new { name = user.nameDataC0_CA, upn = user.upnDataC1, password = user.passwordDataC2, groups = user.groupDataC3, isEnabled = user.isEnabledDataC4, cyberarkAccess = user.cyberAccessDataC5 };
                        string json = JsonConvert.SerializeObject(data);

                        var response = await httpClient.PostAsync(cyberarkApiUrl, new StringContent(json));
                        if (response.IsSuccessStatusCode)
                        {
                            Console.WriteLine("CyberArk API call successful for user: " + user.nameDataC0_CA + "with MiM/RACFID of " + user.upnDataC1);
                        }
                        else
                        {
                            Console.WriteLine("CyberArk API call failed for user: " + user.nameDataC0_CA + "with MiM/RACFID of " + user.upnDataC1);
                        }
                    }
                }
            }
        }

        public class UserInformation
        {
            public string? nameDataC0_CA { get; set; } // CyberArk Naming Conv
            public string? nameDataC0 { get; set; } // Azure Naming Conv
            public string? upnDataC1 { get; set; } // UPN
            public string? passwordDataC2 { get; set; }
            public string? groupDataC3 { get; set; }
            public bool isEnabledDataC4 { get; set; }
            public bool cyberAccessDataC5 { get; set; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}