namespace Active_Directory_Toolbelt.ui.popup
{
    partial class btnExecute
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSelectedFiles = new Label();
            label1 = new Label();
            btnCSVSel = new Button();
            lblSelectCSV = new Label();
            lstViewFiles = new ListView();
            hdrName = new ColumnHeader();
            isEnabled = new ColumnHeader();
            usrPasswd = new ColumnHeader();
            usrGrp = new ColumnHeader();
            hasCbrArkAccess = new ColumnHeader();
            likesCheese = new ColumnHeader();
            btnTest = new Button();
            SuspendLayout();
            // 
            // lblSelectedFiles
            // 
            lblSelectedFiles.AutoSize = true;
            lblSelectedFiles.BackColor = Color.Transparent;
            lblSelectedFiles.FlatStyle = FlatStyle.Flat;
            lblSelectedFiles.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectedFiles.ForeColor = Color.White;
            lblSelectedFiles.Location = new Point(58, 240);
            lblSelectedFiles.Name = "lblSelectedFiles";
            lblSelectedFiles.Size = new Size(127, 13);
            lblSelectedFiles.TabIndex = 18;
            lblSelectedFiles.Text = "%SELECTED_FILE%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 213);
            label1.Name = "label1";
            label1.Size = new Size(119, 13);
            label1.TabIndex = 17;
            label1.Text = "Selected File:";
            // 
            // btnCSVSel
            // 
            btnCSVSel.BackColor = Color.Navy;
            btnCSVSel.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnCSVSel.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnCSVSel.FlatStyle = FlatStyle.Flat;
            btnCSVSel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCSVSel.ForeColor = Color.Salmon;
            btnCSVSel.Location = new Point(57, 118);
            btnCSVSel.Name = "btnCSVSel";
            btnCSVSel.Size = new Size(140, 66);
            btnCSVSel.TabIndex = 16;
            btnCSVSel.Text = "Open CSV";
            btnCSVSel.UseVisualStyleBackColor = false;
            btnCSVSel.Click += btnCSVSel_Click;
            // 
            // lblSelectCSV
            // 
            lblSelectCSV.AutoSize = true;
            lblSelectCSV.BackColor = Color.Transparent;
            lblSelectCSV.FlatStyle = FlatStyle.Flat;
            lblSelectCSV.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectCSV.ForeColor = Color.Tomato;
            lblSelectCSV.Location = new Point(40, 60);
            lblSelectCSV.Name = "lblSelectCSV";
            lblSelectCSV.Size = new Size(178, 44);
            lblSelectCSV.TabIndex = 15;
            lblSelectCSV.Text = "Select CSV File";
            // 
            // lstViewFiles
            // 
            lstViewFiles.Anchor = AnchorStyles.Top;
            lstViewFiles.BackColor = Color.Black;
            lstViewFiles.Columns.AddRange(new ColumnHeader[] { hdrName, isEnabled, usrPasswd, usrGrp, hasCbrArkAccess, likesCheese });
            lstViewFiles.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewFiles.ForeColor = SystemColors.Info;
            lstViewFiles.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstViewFiles.Location = new Point(234, 14);
            lstViewFiles.MultiSelect = false;
            lstViewFiles.Name = "lstViewFiles";
            lstViewFiles.Size = new Size(717, 496);
            lstViewFiles.TabIndex = 28;
            lstViewFiles.UseCompatibleStateImageBehavior = false;
            lstViewFiles.Visible = false;
            // 
            // hdrName
            // 
            hdrName.Width = 170;
            // 
            // isEnabled
            // 
            isEnabled.Width = 90;
            // 
            // usrPasswd
            // 
            usrPasswd.Width = 166;
            // 
            // usrGrp
            // 
            usrGrp.Width = 166;
            // 
            // hasCbrArkAccess
            // 
            hasCbrArkAccess.Width = 80;
            // 
            // likesCheese
            // 
            likesCheese.Width = 80;
            // 
            // btnTest
            // 
            btnTest.BackColor = Color.SeaGreen;
            btnTest.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnTest.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTest.ForeColor = SystemColors.ActiveCaptionText;
            btnTest.Location = new Point(23, 459);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(177, 41);
            btnTest.TabIndex = 39;
            btnTest.Text = "Execute";
            btnTest.UseVisualStyleBackColor = false;
            // 
            // btnExecute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(963, 523);
            Controls.Add(btnTest);
            Controls.Add(lstViewFiles);
            Controls.Add(lblSelectedFiles);
            Controls.Add(label1);
            Controls.Add(btnCSVSel);
            Controls.Add(lblSelectCSV);
            Name = "btnExecute";
            Style = MetroFramework.MetroColorStyle.Orange;
            Text = "FileSelect";
            Theme = MetroFramework.MetroThemeStyle.Dark;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectedFiles;
        private Label label1;
        private Button btnCSVSel;
        private Label lblSelectCSV;
        private ListView lstViewFiles;
        private ColumnHeader hdrName;
        private ColumnHeader isEnabled;
        private ColumnHeader usrPasswd;
        private ColumnHeader usrGrp;
        private ColumnHeader hasCbrArkAccess;
        private ColumnHeader likesCheese;
        private Button btnTest;
    }
}