using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Active_Directory_Toolbelt.ui.popup
{
    public partial class btnExecute : MetroFramework.Forms.MetroForm
    {
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


                foreach (string filePath in openFileDialog.FileNames)
                {
                    lblSelectedFiles.Text = (Path.GetFileName(filePath));
                    lstViewFiles.Columns[0].Text = "Name";
                    //lstViewFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lstViewFiles.Columns[1].Text = "isEnabled";
                    lstViewFiles.Columns[2].Text = "Password";
                    lstViewFiles.Columns[3].Text = "Group(s)";
                    lstViewFiles.Columns[4].Text = "CyberArk Access";
                    lstViewFiles.Columns[5].Text = "likesCheese";
                    // Show only the name of the file in 1 column and the extension in 2nd column and name them accordingly
                    // lstViewFiles.Items.Add(Path.GetFileName(filePath)).SubItems.Add(Path.GetExtension(filePath));
                    // Show file in a row instead of a box
                    lstViewFiles.View = View.Details;

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
            }
        }
    }
}
