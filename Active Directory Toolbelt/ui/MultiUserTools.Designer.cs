namespace Active_Directory_Toolbelt.ui
{
    partial class MultiUserTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiUserTools));
            BtnExit = new Button();
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
            btnReturn = new Button();
            lblDCID = new Label();
            label3 = new Label();
            lblUserID = new Label();
            lblCurrentUser = new Label();
            pictureBox1 = new PictureBox();
            btnDisableAcc = new Button();
            btnEnableAcc = new Button();
            button1 = new Button();
            button2 = new Button();
            pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Navy;
            BtnExit.FlatAppearance.MouseDownBackColor = Color.Blue;
            BtnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.ForeColor = SystemColors.ControlLightLight;
            BtnExit.Location = new Point(12, 7);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(27, 36);
            BtnExit.TabIndex = 33;
            BtnExit.Text = "X";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
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
            pnlUserInfo.Location = new Point(626, 119);
            pnlUserInfo.Name = "pnlUserInfo";
            pnlUserInfo.Size = new Size(391, 373);
            pnlUserInfo.TabIndex = 32;
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
            // btnReturn
            // 
            btnReturn.BackColor = Color.DodgerBlue;
            btnReturn.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturn.ForeColor = SystemColors.ControlLightLight;
            btnReturn.Location = new Point(840, 508);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(177, 36);
            btnReturn.TabIndex = 31;
            btnReturn.Text = "<< Main Menu";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblDCID
            // 
            lblDCID.AutoSize = true;
            lblDCID.BackColor = Color.Transparent;
            lblDCID.FlatStyle = FlatStyle.Flat;
            lblDCID.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDCID.ForeColor = Color.White;
            lblDCID.Location = new Point(129, 508);
            lblDCID.Name = "lblDCID";
            lblDCID.Size = new Size(71, 13);
            lblDCID.TabIndex = 30;
            lblDCID.Text = "%DCTEXT%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 508);
            label3.Name = "label3";
            label3.Size = new Size(95, 13);
            label3.TabIndex = 29;
            label3.Text = "Current DC:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = Color.Transparent;
            lblUserID.FlatStyle = FlatStyle.Flat;
            lblUserID.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserID.ForeColor = Color.White;
            lblUserID.Location = new Point(129, 531);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(87, 13);
            lblUserID.TabIndex = 28;
            lblUserID.Text = "%USERTEXT%";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.BackColor = Color.Transparent;
            lblCurrentUser.FlatStyle = FlatStyle.Flat;
            lblCurrentUser.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentUser.ForeColor = Color.White;
            lblCurrentUser.Location = new Point(12, 531);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(111, 13);
            lblCurrentUser.TabIndex = 27;
            lblCurrentUser.Text = "Current User:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Activedirectory_logo;
            pictureBox1.Location = new Point(59, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(588, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
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
            btnDisableAcc.Location = new Point(273, 363);
            btnDisableAcc.Name = "btnDisableAcc";
            btnDisableAcc.Size = new Size(197, 41);
            btnDisableAcc.TabIndex = 35;
            btnDisableAcc.Text = "Disable Accounts";
            btnDisableAcc.UseVisualStyleBackColor = false;
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
            btnEnableAcc.Location = new Point(59, 363);
            btnEnableAcc.Name = "btnEnableAcc";
            btnEnableAcc.Size = new Size(177, 41);
            btnEnableAcc.TabIndex = 34;
            btnEnableAcc.Text = "Enable Accounts";
            btnEnableAcc.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Enabled = false;
            button1.FlatAppearance.MouseDownBackColor = Color.Crimson;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(273, 188);
            button1.Name = "button1";
            button1.Size = new Size(197, 41);
            button1.TabIndex = 37;
            button1.Text = "Bulk Delete Accounts";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.Enabled = false;
            button2.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            button2.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(59, 188);
            button2.Name = "button2";
            button2.Size = new Size(177, 41);
            button2.TabIndex = 36;
            button2.Text = "Bulk Create Accounts";
            button2.UseVisualStyleBackColor = false;
            // 
            // MultiUserTools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 553);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(btnDisableAcc);
            Controls.Add(btnEnableAcc);
            Controls.Add(BtnExit);
            Controls.Add(pnlUserInfo);
            Controls.Add(btnReturn);
            Controls.Add(lblDCID);
            Controls.Add(label3);
            Controls.Add(lblUserID);
            Controls.Add(lblCurrentUser);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MultiUserTools";
            Style = MetroFramework.MetroColorStyle.Yellow;
            Text = "MultiUserTools";
            TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            Theme = MetroFramework.MetroThemeStyle.Dark;
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnExit;
        private Panel pnlUserInfo;
        private Label varUserManager;
        private Label varIsDisabled;
        private Label varIsLocked;
        private Label varUserEmail;
        private Label varUserName;
        private Label lblManager;
        private Label label9;
        private Label lblisDisabled;
        private Label lblLockStatus;
        private Label lblAccStatus;
        private Label lblEmail;
        private Label lblName;
        private Label lblUserInfo;
        private Button btnReturn;
        private Label lblDCID;
        private Label label3;
        private Label lblUserID;
        private Label lblCurrentUser;
        private PictureBox pictureBox1;
        private Button btnDisableAcc;
        private Button btnEnableAcc;
        private Button button1;
        private Button button2;
    }
}