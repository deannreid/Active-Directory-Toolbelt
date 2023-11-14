namespace Active_Directory_Toolbelt.ui
{
    partial class PSExecutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PSExecutor));
            btnReturn = new Button();
            dlgFolderBrowser = new FolderBrowserDialog();
            btnSelectFolder = new Button();
            lstViewFiles = new ListView();
            fileName = new ColumnHeader();
            fileTypeExt = new ColumnHeader();
            btnExecute = new Button();
            BtnExit = new Button();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.DodgerBlue;
            btnReturn.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturn.ForeColor = SystemColors.ControlLightLight;
            btnReturn.Location = new Point(8, 20);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(29, 36);
            btnReturn.TabIndex = 25;
            btnReturn.Text = "<";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += BtnReturn_Click;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.BackColor = Color.DodgerBlue;
            btnSelectFolder.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnSelectFolder.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnSelectFolder.FlatStyle = FlatStyle.Flat;
            btnSelectFolder.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectFolder.ForeColor = SystemColors.ControlLightLight;
            btnSelectFolder.Location = new Point(8, 585);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(147, 36);
            btnSelectFolder.TabIndex = 26;
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.UseVisualStyleBackColor = false;
            btnSelectFolder.Click += BtnSelectFolder_Click;
            // 
            // lstViewFiles
            // 
            lstViewFiles.BackColor = Color.Black;
            lstViewFiles.Columns.AddRange(new ColumnHeader[] { fileName, fileTypeExt });
            lstViewFiles.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstViewFiles.ForeColor = SystemColors.Info;
            lstViewFiles.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstViewFiles.Location = new Point(8, 63);
            lstViewFiles.MultiSelect = false;
            lstViewFiles.Name = "lstViewFiles";
            lstViewFiles.Size = new Size(405, 516);
            lstViewFiles.TabIndex = 27;
            lstViewFiles.UseCompatibleStateImageBehavior = false;
            // 
            // btnExecute
            // 
            btnExecute.BackColor = Color.Crimson;
            btnExecute.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnExecute.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnExecute.FlatStyle = FlatStyle.Flat;
            btnExecute.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExecute.ForeColor = SystemColors.ControlLightLight;
            btnExecute.Location = new Point(224, 585);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(177, 36);
            btnExecute.TabIndex = 28;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = false;
            btnExecute.Click += btnExecute_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Navy;
            BtnExit.FlatAppearance.MouseDownBackColor = Color.Blue;
            BtnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.ForeColor = SystemColors.ControlLightLight;
            BtnExit.Location = new Point(365, 21);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(27, 36);
            BtnExit.TabIndex = 29;
            BtnExit.Text = "X";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // PSExecutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 637);
            ControlBox = false;
            Controls.Add(BtnExit);
            Controls.Add(btnExecute);
            Controls.Add(lstViewFiles);
            Controls.Add(btnSelectFolder);
            Controls.Add(btnReturn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PSExecutor";
            Style = MetroFramework.MetroColorStyle.White;
            Text = "Powershell Executor";
            TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            Theme = MetroFramework.MetroThemeStyle.Dark;
            ResumeLayout(false);
        }

        #endregion

        private Button btnReturn;
        private FolderBrowserDialog dlgFolderBrowser;
        private Button btnSelectFolder;
        private ListView lstViewFiles;
        private Button btnExecute;
        private ColumnHeader fileName;
        private ColumnHeader fileTypeExt;
        private Button BtnExit;
    }
}