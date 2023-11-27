namespace Active_Directory_Toolbelt.ui
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            pictureBox1 = new PictureBox();
            lblHeader = new Label();
            btnUserTools = new Button();
            lblCurrentUser = new Label();
            lblUserID = new Label();
            lblDCID = new Label();
            label3 = new Label();
            btnAssetTools = new Button();
            btnCloudTools = new Button();
            btnAdmin = new Button();
            btnPSExec = new Button();
            BtnExit = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Activedirectory_logo;
            pictureBox1.Location = new Point(23, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(588, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.FlatStyle = FlatStyle.Flat;
            lblHeader.Font = new Font("MV Boli", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = SystemColors.ButtonHighlight;
            lblHeader.Location = new Point(479, 145);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(90, 39);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Tools";
            // 
            // btnUserTools
            // 
            btnUserTools.BackColor = Color.Navy;
            btnUserTools.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnUserTools.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnUserTools.FlatStyle = FlatStyle.Flat;
            btnUserTools.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUserTools.ForeColor = SystemColors.ControlLightLight;
            btnUserTools.Location = new Point(151, 198);
            btnUserTools.Name = "btnUserTools";
            btnUserTools.Size = new Size(138, 66);
            btnUserTools.TabIndex = 2;
            btnUserTools.Text = "Single \r\nUser Tools";
            btnUserTools.UseVisualStyleBackColor = false;
            btnUserTools.Click += BtnUserTools_Click;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.BackColor = Color.Transparent;
            lblCurrentUser.FlatStyle = FlatStyle.Flat;
            lblCurrentUser.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentUser.ForeColor = Color.White;
            lblCurrentUser.Location = new Point(7, 531);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(111, 13);
            lblCurrentUser.TabIndex = 3;
            lblCurrentUser.Text = "Current User:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = Color.Transparent;
            lblUserID.FlatStyle = FlatStyle.Flat;
            lblUserID.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserID.ForeColor = Color.White;
            lblUserID.Location = new Point(124, 531);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(87, 13);
            lblUserID.TabIndex = 4;
            lblUserID.Text = "%USERTEXT%";
            // 
            // lblDCID
            // 
            lblDCID.AutoSize = true;
            lblDCID.BackColor = Color.Transparent;
            lblDCID.FlatStyle = FlatStyle.Flat;
            lblDCID.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDCID.ForeColor = Color.White;
            lblDCID.Location = new Point(124, 508);
            lblDCID.Name = "lblDCID";
            lblDCID.Size = new Size(71, 13);
            lblDCID.TabIndex = 6;
            lblDCID.Text = "%DCTEXT%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(7, 508);
            label3.Name = "label3";
            label3.Size = new Size(95, 13);
            label3.TabIndex = 5;
            label3.Text = "Current DC:";
            // 
            // btnAssetTools
            // 
            btnAssetTools.BackColor = Color.Navy;
            btnAssetTools.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnAssetTools.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnAssetTools.FlatStyle = FlatStyle.Flat;
            btnAssetTools.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAssetTools.ForeColor = SystemColors.ControlLightLight;
            btnAssetTools.Location = new Point(151, 281);
            btnAssetTools.Name = "btnAssetTools";
            btnAssetTools.Size = new Size(308, 66);
            btnAssetTools.TabIndex = 7;
            btnAssetTools.Text = "Asset Tools";
            btnAssetTools.UseVisualStyleBackColor = false;
            btnAssetTools.Click += BtnAssetTools_Click;
            // 
            // btnCloudTools
            // 
            btnCloudTools.BackColor = Color.Navy;
            btnCloudTools.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnCloudTools.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnCloudTools.FlatStyle = FlatStyle.Flat;
            btnCloudTools.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCloudTools.ForeColor = SystemColors.ControlLightLight;
            btnCloudTools.Location = new Point(151, 365);
            btnCloudTools.Name = "btnCloudTools";
            btnCloudTools.Size = new Size(308, 66);
            btnCloudTools.TabIndex = 8;
            btnCloudTools.Text = "Cloud Tools";
            btnCloudTools.UseVisualStyleBackColor = false;
            btnCloudTools.Click += BtnCloudTools_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Navy;
            btnAdmin.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdmin.ForeColor = SystemColors.ControlLightLight;
            btnAdmin.Location = new Point(471, 477);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(140, 66);
            btnAdmin.TabIndex = 9;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += BtnAdmin_Click;
            // 
            // btnPSExec
            // 
            btnPSExec.BackColor = Color.Navy;
            btnPSExec.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnPSExec.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnPSExec.FlatStyle = FlatStyle.Flat;
            btnPSExec.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPSExec.ForeColor = SystemColors.ControlLightLight;
            btnPSExec.Location = new Point(307, 477);
            btnPSExec.Name = "btnPSExec";
            btnPSExec.Size = new Size(140, 66);
            btnPSExec.TabIndex = 10;
            btnPSExec.Text = "PowerShell Executor";
            btnPSExec.UseVisualStyleBackColor = false;
            btnPSExec.Click += BtnPSExec_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Navy;
            BtnExit.FlatAppearance.MouseDownBackColor = Color.Blue;
            BtnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.ForeColor = SystemColors.ControlLightLight;
            BtnExit.Location = new Point(584, 14);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(27, 36);
            BtnExit.TabIndex = 11;
            BtnExit.Text = "X";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.MouseDownBackColor = Color.Blue;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(321, 198);
            button1.Name = "button1";
            button1.Size = new Size(138, 66);
            button1.TabIndex = 12;
            button1.Text = "Multi\r\nUser Tools";
            button1.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(632, 553);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(BtnExit);
            Controls.Add(btnPSExec);
            Controls.Add(btnAdmin);
            Controls.Add(btnCloudTools);
            Controls.Add(btnAssetTools);
            Controls.Add(lblDCID);
            Controls.Add(label3);
            Controls.Add(lblUserID);
            Controls.Add(lblCurrentUser);
            Controls.Add(btnUserTools);
            Controls.Add(lblHeader);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainMenu";
            Resizable = false;
            Style = MetroFramework.MetroColorStyle.Blue;
            Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHeader;
        private Button btnUserTools;
        private Label lblCurrentUser;
        private Label lblUserID;
        private Label lblDCID;
        private Label label3;
        private Button btnAssetTools;
        private Button btnCloudTools;
        private Button btnAdmin;
        private Button btnPSExec;
        private Button BtnExit;
        private Button button1;
    }
}