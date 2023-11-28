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
            btnReturn = new Button();
            lblDCID = new Label();
            label3 = new Label();
            lblUserID = new Label();
            lblCurrentUser = new Label();
            button2 = new Button();
            button1 = new Button();
            btnTest = new Button();
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
            BtnExit.Location = new Point(23, 26);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(27, 36);
            BtnExit.TabIndex = 33;
            BtnExit.Text = "X";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.DodgerBlue;
            btnReturn.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturn.ForeColor = SystemColors.ControlLightLight;
            btnReturn.Location = new Point(23, 287);
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
            lblDCID.Location = new Point(497, 365);
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
            label3.Location = new Point(380, 365);
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
            lblUserID.Location = new Point(129, 365);
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
            lblCurrentUser.Location = new Point(12, 365);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(111, 13);
            lblCurrentUser.TabIndex = 27;
            lblCurrentUser.Text = "Current User:";
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
            button2.Location = new Point(131, 82);
            button2.Name = "button2";
            button2.Size = new Size(177, 41);
            button2.TabIndex = 36;
            button2.Text = "Bulk Create Accounts";
            button2.UseVisualStyleBackColor = false;
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
            button1.Location = new Point(347, 82);
            button1.Name = "button1";
            button1.Size = new Size(177, 41);
            button1.TabIndex = 37;
            button1.Text = "Bulk Delete Accounts";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnTest
            // 
            btnTest.BackColor = Color.SeaGreen;
            btnTest.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnTest.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTest.ForeColor = SystemColors.ActiveCaptionText;
            btnTest.Location = new Point(131, 160);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(177, 41);
            btnTest.TabIndex = 38;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // MultiUserTools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 391);
            ControlBox = false;
            Controls.Add(btnTest);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(BtnExit);
            Controls.Add(btnReturn);
            Controls.Add(lblDCID);
            Controls.Add(label3);
            Controls.Add(lblUserID);
            Controls.Add(lblCurrentUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MultiUserTools";
            Style = MetroFramework.MetroColorStyle.Yellow;
            Text = "MultiUserTools";
            TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            Theme = MetroFramework.MetroThemeStyle.Dark;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnExit;
        private Button btnReturn;
        private Label lblDCID;
        private Label label3;
        private Label lblUserID;
        private Label lblCurrentUser;
        private Button button2;
        private Button button1;
        private Button btnTest;
    }
}