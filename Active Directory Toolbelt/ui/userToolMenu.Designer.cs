namespace Active_Directory_Toolbelt.ui
{
    partial class UserToolMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserToolMenu));
            lblDCID = new Label();
            label3 = new Label();
            lblUserID = new Label();
            lblCurrentUser = new Label();
            lblHeader = new Label();
            pictureBox1 = new PictureBox();
            btnReturn = new Button();
            lblEnterID = new Label();
            txtbxUserID = new TextBox();
            btnSelectID = new Button();
            pnlUserInfo = new Panel();
            varUserManager = new Label();
            varIsDisabled = new Label();
            varIsLocked = new Label();
            varUserEmail = new Label();
            varUserName = new Label();
            lblManager = new Label();
            label9 = new Label();
            lblisDisabled = new Label();
            lblLockStatus = new Label();
            lblAccStatus = new Label();
            lblEmail = new Label();
            lblName = new Label();
            lblUserInfo = new Label();
            btnUnlockAcc = new Button();
            btnEnableAcc = new Button();
            btnDisableAcc = new Button();
            btnSetPasswd = new Button();
            txtPasswdEntry = new TextBox();
            label7 = new Label();
            BtnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlUserInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblDCID
            // 
            lblDCID.AutoSize = true;
            lblDCID.BackColor = Color.Transparent;
            lblDCID.FlatStyle = FlatStyle.Flat;
            lblDCID.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDCID.ForeColor = Color.White;
            lblDCID.Location = new Point(124, 571);
            lblDCID.Name = "lblDCID";
            lblDCID.Size = new Size(71, 13);
            lblDCID.TabIndex = 12;
            lblDCID.Text = "%DCTEXT%";
            lblDCID.Click += lblDCID_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(7, 571);
            label3.Name = "label3";
            label3.Size = new Size(95, 13);
            label3.TabIndex = 11;
            label3.Text = "Current DC:";
            label3.Click += label3_Click;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = Color.Transparent;
            lblUserID.FlatStyle = FlatStyle.Flat;
            lblUserID.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserID.ForeColor = Color.White;
            lblUserID.Location = new Point(124, 594);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(87, 13);
            lblUserID.TabIndex = 10;
            lblUserID.Text = "%USERTEXT%";
            lblUserID.Click += lblUserID_Click;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.BackColor = Color.Transparent;
            lblCurrentUser.FlatStyle = FlatStyle.Flat;
            lblCurrentUser.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentUser.ForeColor = Color.White;
            lblCurrentUser.Location = new Point(7, 594);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(111, 13);
            lblCurrentUser.TabIndex = 9;
            lblCurrentUser.Text = "Current User:";
            lblCurrentUser.Click += lblCurrentUser_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.FlatStyle = FlatStyle.Flat;
            lblHeader.Font = new Font("MV Boli", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = SystemColors.ButtonHighlight;
            lblHeader.Location = new Point(537, 105);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(90, 39);
            lblHeader.TabIndex = 8;
            lblHeader.Text = "Tools";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Activedirectory_logo;
            pictureBox1.Location = new Point(78, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(588, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.DodgerBlue;
            btnReturn.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturn.ForeColor = SystemColors.ControlLightLight;
            btnReturn.Location = new Point(699, 558);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(177, 36);
            btnReturn.TabIndex = 13;
            btnReturn.Text = "<< Main Menu";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblEnterID
            // 
            lblEnterID.AutoSize = true;
            lblEnterID.BackColor = Color.Transparent;
            lblEnterID.FlatStyle = FlatStyle.Flat;
            lblEnterID.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnterID.ForeColor = Color.White;
            lblEnterID.Location = new Point(23, 197);
            lblEnterID.Name = "lblEnterID";
            lblEnterID.Size = new Size(183, 13);
            lblEnterID.TabIndex = 14;
            lblEnterID.Text = "Enter User SAML or UPN";
            // 
            // txtbxUserID
            // 
            txtbxUserID.BackColor = SystemColors.InactiveCaptionText;
            txtbxUserID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbxUserID.ForeColor = SystemColors.Menu;
            txtbxUserID.Location = new Point(212, 188);
            txtbxUserID.MaxLength = 15;
            txtbxUserID.Name = "txtbxUserID";
            txtbxUserID.PlaceholderText = "Enter ID";
            txtbxUserID.Size = new Size(121, 27);
            txtbxUserID.TabIndex = 15;
            txtbxUserID.TextAlign = HorizontalAlignment.Center;
            txtbxUserID.WordWrap = false;
            // 
            // btnSelectID
            // 
            btnSelectID.BackColor = Color.DodgerBlue;
            btnSelectID.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnSelectID.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnSelectID.FlatStyle = FlatStyle.Flat;
            btnSelectID.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectID.ForeColor = SystemColors.ControlLightLight;
            btnSelectID.Location = new Point(339, 188);
            btnSelectID.Name = "btnSelectID";
            btnSelectID.Size = new Size(69, 27);
            btnSelectID.TabIndex = 16;
            btnSelectID.Text = "Select";
            btnSelectID.UseVisualStyleBackColor = false;
            btnSelectID.Click += btnSelectID_Click;
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.BackColor = Color.FromArgb(19, 19, 19);
            pnlUserInfo.Controls.Add(varUserManager);
            pnlUserInfo.Controls.Add(varIsDisabled);
            pnlUserInfo.Controls.Add(varIsLocked);
            pnlUserInfo.Controls.Add(varUserEmail);
            pnlUserInfo.Controls.Add(varUserName);
            pnlUserInfo.Controls.Add(lblManager);
            pnlUserInfo.Controls.Add(label9);
            pnlUserInfo.Controls.Add(lblisDisabled);
            pnlUserInfo.Controls.Add(lblLockStatus);
            pnlUserInfo.Controls.Add(lblAccStatus);
            pnlUserInfo.Controls.Add(lblEmail);
            pnlUserInfo.Controls.Add(lblName);
            pnlUserInfo.Controls.Add(lblUserInfo);
            pnlUserInfo.Location = new Point(524, 169);
            pnlUserInfo.Name = "pnlUserInfo";
            pnlUserInfo.Size = new Size(375, 373);
            pnlUserInfo.TabIndex = 17;
            pnlUserInfo.Paint += pnlUserInfo_Paint;
            // 
            // varUserManager
            // 
            varUserManager.AutoSize = true;
            varUserManager.BackColor = Color.Transparent;
            varUserManager.FlatStyle = FlatStyle.Flat;
            varUserManager.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            varUserManager.ForeColor = Color.FromArgb(192, 255, 192);
            varUserManager.Location = new Point(133, 93);
            varUserManager.Name = "varUserManager";
            varUserManager.Size = new Size(119, 13);
            varUserManager.TabIndex = 29;
            varUserManager.Text = "%USER_MANAGER%";
            // 
            // varIsDisabled
            // 
            varIsDisabled.AutoSize = true;
            varIsDisabled.BackColor = Color.Transparent;
            varIsDisabled.FlatStyle = FlatStyle.Flat;
            varIsDisabled.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            varIsDisabled.ForeColor = Color.Red;
            varIsDisabled.Location = new Point(133, 193);
            varIsDisabled.Name = "varIsDisabled";
            varIsDisabled.Size = new Size(111, 13);
            varIsDisabled.TabIndex = 28;
            varIsDisabled.Text = "%IS_DISABLED%";
            // 
            // varIsLocked
            // 
            varIsLocked.AutoSize = true;
            varIsLocked.BackColor = Color.Transparent;
            varIsLocked.FlatStyle = FlatStyle.Flat;
            varIsLocked.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            varIsLocked.ForeColor = Color.FromArgb(192, 255, 192);
            varIsLocked.Location = new Point(133, 170);
            varIsLocked.Name = "varIsLocked";
            varIsLocked.Size = new Size(95, 13);
            varIsLocked.TabIndex = 27;
            varIsLocked.Text = "%IS_LOCKED%";
            // 
            // varUserEmail
            // 
            varUserEmail.AutoSize = true;
            varUserEmail.BackColor = Color.Transparent;
            varUserEmail.FlatStyle = FlatStyle.Flat;
            varUserEmail.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            varUserEmail.ForeColor = Color.FromArgb(192, 255, 192);
            varUserEmail.Location = new Point(133, 69);
            varUserEmail.Name = "varUserEmail";
            varUserEmail.Size = new Size(103, 13);
            varUserEmail.TabIndex = 26;
            varUserEmail.Text = "%USER_EMAIL%";
            // 
            // varUserName
            // 
            varUserName.AutoSize = true;
            varUserName.BackColor = Color.Transparent;
            varUserName.FlatStyle = FlatStyle.Flat;
            varUserName.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            varUserName.ForeColor = Color.FromArgb(192, 255, 192);
            varUserName.Location = new Point(133, 44);
            varUserName.Name = "varUserName";
            varUserName.Size = new Size(87, 13);
            varUserName.TabIndex = 25;
            varUserName.Text = "%USERNAME%";
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.BackColor = Color.Transparent;
            lblManager.FlatStyle = FlatStyle.Flat;
            lblManager.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblManager.ForeColor = Color.White;
            lblManager.Location = new Point(8, 93);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(63, 13);
            lblManager.TabIndex = 24;
            lblManager.Text = "Manager";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(8, 118);
            label9.Name = "label9";
            label9.Size = new Size(287, 13);
            label9.TabIndex = 23;
            label9.Text = "___________________________________";
            // 
            // lblisDisabled
            // 
            lblisDisabled.AutoSize = true;
            lblisDisabled.BackColor = Color.Transparent;
            lblisDisabled.FlatStyle = FlatStyle.Flat;
            lblisDisabled.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblisDisabled.ForeColor = Color.White;
            lblisDisabled.Location = new Point(8, 193);
            lblisDisabled.Name = "lblisDisabled";
            lblisDisabled.Size = new Size(71, 13);
            lblisDisabled.TabIndex = 22;
            lblisDisabled.Text = "Disabled";
            // 
            // lblLockStatus
            // 
            lblLockStatus.AutoSize = true;
            lblLockStatus.BackColor = Color.Transparent;
            lblLockStatus.FlatStyle = FlatStyle.Flat;
            lblLockStatus.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLockStatus.ForeColor = Color.White;
            lblLockStatus.Location = new Point(8, 170);
            lblLockStatus.Name = "lblLockStatus";
            lblLockStatus.Size = new Size(95, 13);
            lblLockStatus.TabIndex = 21;
            lblLockStatus.Text = "Lock Status";
            // 
            // lblAccStatus
            // 
            lblAccStatus.AutoSize = true;
            lblAccStatus.BackColor = Color.Transparent;
            lblAccStatus.FlatStyle = FlatStyle.Flat;
            lblAccStatus.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccStatus.ForeColor = Color.White;
            lblAccStatus.Location = new Point(8, 144);
            lblAccStatus.Name = "lblAccStatus";
            lblAccStatus.Size = new Size(133, 13);
            lblAccStatus.TabIndex = 20;
            lblAccStatus.Text = "Account Status";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.FlatStyle = FlatStyle.Flat;
            lblEmail.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(8, 69);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 13);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(8, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 13);
            lblName.TabIndex = 18;
            lblName.Text = "Name";
            // 
            // lblUserInfo
            // 
            lblUserInfo.AutoSize = true;
            lblUserInfo.BackColor = Color.Transparent;
            lblUserInfo.FlatStyle = FlatStyle.Flat;
            lblUserInfo.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserInfo.ForeColor = Color.White;
            lblUserInfo.Location = new Point(8, 17);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(151, 13);
            lblUserInfo.TabIndex = 18;
            lblUserInfo.Text = "User Information";
            // 
            // btnUnlockAcc
            // 
            btnUnlockAcc.BackColor = Color.SeaGreen;
            btnUnlockAcc.Enabled = false;
            btnUnlockAcc.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnUnlockAcc.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnUnlockAcc.FlatStyle = FlatStyle.Flat;
            btnUnlockAcc.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUnlockAcc.ForeColor = SystemColors.ActiveCaptionText;
            btnUnlockAcc.Location = new Point(143, 272);
            btnUnlockAcc.Name = "btnUnlockAcc";
            btnUnlockAcc.Size = new Size(177, 41);
            btnUnlockAcc.TabIndex = 18;
            btnUnlockAcc.Text = "Unlock Account";
            btnUnlockAcc.UseVisualStyleBackColor = false;
            btnUnlockAcc.Click += btnUnlockAcc_Click;
            // 
            // btnEnableAcc
            // 
            btnEnableAcc.BackColor = Color.SeaGreen;
            btnEnableAcc.Enabled = false;
            btnEnableAcc.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnEnableAcc.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnEnableAcc.FlatStyle = FlatStyle.Flat;
            btnEnableAcc.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnableAcc.ForeColor = SystemColors.ActiveCaptionText;
            btnEnableAcc.Location = new Point(34, 334);
            btnEnableAcc.Name = "btnEnableAcc";
            btnEnableAcc.Size = new Size(177, 41);
            btnEnableAcc.TabIndex = 19;
            btnEnableAcc.Text = "Enable Account";
            btnEnableAcc.UseVisualStyleBackColor = false;
            btnEnableAcc.Click += btnEnableAcc_Click;
            // 
            // btnDisableAcc
            // 
            btnDisableAcc.BackColor = Color.Salmon;
            btnDisableAcc.Enabled = false;
            btnDisableAcc.FlatAppearance.MouseDownBackColor = Color.Crimson;
            btnDisableAcc.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnDisableAcc.FlatStyle = FlatStyle.Flat;
            btnDisableAcc.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisableAcc.ForeColor = SystemColors.ControlLightLight;
            btnDisableAcc.Location = new Point(248, 334);
            btnDisableAcc.Name = "btnDisableAcc";
            btnDisableAcc.Size = new Size(197, 41);
            btnDisableAcc.TabIndex = 21;
            btnDisableAcc.Text = "Disable Account";
            btnDisableAcc.UseVisualStyleBackColor = false;
            btnDisableAcc.Click += btnDisableAcc_Click;
            // 
            // btnSetPasswd
            // 
            btnSetPasswd.BackColor = Color.SkyBlue;
            btnSetPasswd.Enabled = false;
            btnSetPasswd.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnSetPasswd.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnSetPasswd.FlatStyle = FlatStyle.Flat;
            btnSetPasswd.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetPasswd.ForeColor = SystemColors.ControlLightLight;
            btnSetPasswd.Location = new Point(207, 516);
            btnSetPasswd.Name = "btnSetPasswd";
            btnSetPasswd.Size = new Size(124, 27);
            btnSetPasswd.TabIndex = 24;
            btnSetPasswd.Text = "Set Password";
            btnSetPasswd.UseVisualStyleBackColor = false;
            btnSetPasswd.Click += btnSetPasswd_Click;
            // 
            // txtPasswdEntry
            // 
            txtPasswdEntry.BackColor = SystemColors.InactiveCaptionText;
            txtPasswdEntry.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPasswdEntry.ForeColor = SystemColors.Menu;
            txtPasswdEntry.Location = new Point(18, 515);
            txtPasswdEntry.MaxLength = 25;
            txtPasswdEntry.Name = "txtPasswdEntry";
            txtPasswdEntry.PlaceholderText = "Enter Pasword";
            txtPasswdEntry.Size = new Size(183, 27);
            txtPasswdEntry.TabIndex = 23;
            txtPasswdEntry.TextAlign = HorizontalAlignment.Center;
            txtPasswdEntry.UseSystemPasswordChar = true;
            txtPasswdEntry.WordWrap = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(18, 489);
            label7.Name = "label7";
            label7.Size = new Size(167, 13);
            label7.TabIndex = 22;
            label7.Text = "Change User Password";
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Navy;
            BtnExit.FlatAppearance.MouseDownBackColor = Color.Blue;
            BtnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.ForeColor = SystemColors.ControlLightLight;
            BtnExit.Location = new Point(849, 18);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(27, 36);
            BtnExit.TabIndex = 25;
            BtnExit.Text = "X";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // UserToolMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 617);
            ControlBox = false;
            Controls.Add(BtnExit);
            Controls.Add(btnSetPasswd);
            Controls.Add(txtPasswdEntry);
            Controls.Add(label7);
            Controls.Add(btnDisableAcc);
            Controls.Add(btnEnableAcc);
            Controls.Add(btnUnlockAcc);
            Controls.Add(pnlUserInfo);
            Controls.Add(btnSelectID);
            Controls.Add(txtbxUserID);
            Controls.Add(lblEnterID);
            Controls.Add(btnReturn);
            Controls.Add(lblDCID);
            Controls.Add(label3);
            Controls.Add(lblUserID);
            Controls.Add(lblCurrentUser);
            Controls.Add(lblHeader);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UserToolMenu";
            Resizable = false;
            Style = MetroFramework.MetroColorStyle.Red;
            Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDCID;
        private Label label3;
        private Label lblUserID;
        private Label lblCurrentUser;
        private Label lblHeader;
        private PictureBox pictureBox1;
        private Button btnReturn;
        private Label lblEnterID;
        private TextBox txtbxUserID;
        private Button btnSelectID;
        private Panel pnlUserInfo;
        private Label lblisDisabled;
        private Label lblLockStatus;
        private Label lblAccStatus;
        private Label lblEmail;
        private Label lblName;
        private Label lblUserInfo;
        private Label lblManager;
        private Label label9;
        private Label varUserManager;
        private Label varIsDisabled;
        private Label varIsLocked;
        private Label varUserEmail;
        private Label varUserName;
        private Button btnUnlockAcc;
        private Button btnEnableAcc;
        private Button btnDisableAcc;
        private Button btnSetPasswd;
        private TextBox txtPasswdEntry;
        private Label label7;
        private Button BtnExit;
    }
}