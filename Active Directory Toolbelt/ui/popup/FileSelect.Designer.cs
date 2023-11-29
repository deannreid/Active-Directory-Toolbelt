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
            upnAddr = new ColumnHeader();
            usrPasswd = new ColumnHeader();
            usrGrp = new ColumnHeader();
            isEnabled = new ColumnHeader();
            hasCbrArkAccess = new ColumnHeader();
            btnTest = new Button();
            BtnExit = new Button();
            SuspendLayout();
            // 
            // lblSelectedFiles
            // 
            lblSelectedFiles.AutoSize = true;
            lblSelectedFiles.BackColor = Color.Transparent;
            lblSelectedFiles.FlatStyle = FlatStyle.Flat;
            lblSelectedFiles.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectedFiles.ForeColor = Color.White;
            lblSelectedFiles.Location = new Point(70, 240);
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
            label1.Click += label1_Click;
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
            lstViewFiles.Columns.AddRange(new ColumnHeader[] { hdrName, upnAddr, usrPasswd, usrGrp, isEnabled, hasCbrArkAccess });
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
            hdrName.Width = 90;
            // 
            // upnAddr
            // 
            upnAddr.Width = 130;
            // 
            // usrPasswd
            // 
            usrPasswd.Width = 130;
            // 
            // usrGrp
            // 
            usrGrp.Width = 150;
            // 
            // isEnabled
            // 
            isEnabled.Width = 100;
            // 
            // hasCbrArkAccess
            // 
            hasCbrArkAccess.Width = 150;
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
            btnTest.Click += btnTest_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Navy;
            BtnExit.FlatAppearance.MouseDownBackColor = Color.Blue;
            BtnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.ForeColor = SystemColors.ControlLightLight;
            BtnExit.Location = new Point(179, 14);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(21, 31);
            BtnExit.TabIndex = 40;
            BtnExit.Text = "X";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // btnExecute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(963, 523);
            ControlBox = false;
            Controls.Add(BtnExit);
            Controls.Add(btnTest);
            Controls.Add(lstViewFiles);
            Controls.Add(lblSelectedFiles);
            Controls.Add(label1);
            Controls.Add(btnCSVSel);
            Controls.Add(lblSelectCSV);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "btnExecute";
            Resizable = false;
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
        private Button btnTest;
        private ColumnHeader upnAddr;
        private Button BtnExit;
    }
}