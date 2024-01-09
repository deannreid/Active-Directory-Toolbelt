namespace Active_Directory_Toolbelt.ui
{
    partial class AdminTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTools));
            lblHeader = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cmbIDPlatform = new ComboBox();
            label5 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            btnAzure = new PictureBox();
            label4 = new Label();
            varCloudAppID = new Label();
            varCloudTenantID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAzure).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.FlatStyle = FlatStyle.Flat;
            lblHeader.Font = new Font("MV Boli", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = SystemColors.ButtonHighlight;
            lblHeader.Location = new Point(482, 116);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(90, 39);
            lblHeader.TabIndex = 30;
            lblHeader.Text = "Tools";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Activedirectory_logo;
            pictureBox1.Location = new Point(23, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(588, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("MV Boli", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(190, 167);
            label1.Name = "label1";
            label1.Size = new Size(308, 39);
            label1.TabIndex = 32;
            label1.Text = "Administrator Menu";
            // 
            // cmbIDPlatform
            // 
            cmbIDPlatform.BackColor = SystemColors.MenuText;
            cmbIDPlatform.ForeColor = SystemColors.Info;
            cmbIDPlatform.FormattingEnabled = true;
            cmbIDPlatform.Items.AddRange(new object[] { "Amazon AWS", "Azure Entra ID", "Microsoft AD FS", "Google Cloud Platform", "IBM Cloud" });
            cmbIDPlatform.Location = new Point(199, 240);
            cmbIDPlatform.Name = "cmbIDPlatform";
            cmbIDPlatform.Size = new Size(190, 23);
            cmbIDPlatform.TabIndex = 33;
            cmbIDPlatform.SelectedIndexChanged += cmbIDPlatform_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(212, 224);
            label5.Name = "label5";
            label5.Size = new Size(143, 13);
            label5.TabIndex = 35;
            label5.Text = "Identity Platform";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 19, 19);
            panel1.Controls.Add(varCloudAppID);
            panel1.Controls.Add(varCloudTenantID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAzure);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(23, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 345);
            panel1.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 135);
            label2.Name = "label2";
            label2.Size = new Size(133, 13);
            label2.TabIndex = 35;
            label2.Text = "Application ID";
            // 
            // btnAzure
            // 
            btnAzure.Image = (Image)resources.GetObject("btnAzure.Image");
            btnAzure.Location = new Point(3, 0);
            btnAzure.Name = "btnAzure";
            btnAzure.Size = new Size(100, 76);
            btnAzure.SizeMode = PictureBoxSizeMode.Zoom;
            btnAzure.TabIndex = 34;
            btnAzure.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 102);
            label4.Name = "label4";
            label4.Size = new Size(88, 13);
            label4.TabIndex = 20;
            label4.Text = "Tenant ID";
            // 
            // varCloudAppID
            // 
            varCloudAppID.AutoSize = true;
            varCloudAppID.BackColor = Color.Transparent;
            varCloudAppID.FlatStyle = FlatStyle.Flat;
            varCloudAppID.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            varCloudAppID.ForeColor = Color.White;
            varCloudAppID.Location = new Point(167, 135);
            varCloudAppID.Name = "varCloudAppID";
            varCloudAppID.Size = new Size(106, 13);
            varCloudAppID.TabIndex = 37;
            varCloudAppID.Text = "%CLDAPP_ID%";
            // 
            // varCloudTenantID
            // 
            varCloudTenantID.AutoSize = true;
            varCloudTenantID.BackColor = Color.Transparent;
            varCloudTenantID.FlatStyle = FlatStyle.Flat;
            varCloudTenantID.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            varCloudTenantID.ForeColor = Color.White;
            varCloudTenantID.Location = new Point(167, 102);
            varCloudTenantID.Name = "varCloudTenantID";
            varCloudTenantID.Size = new Size(106, 13);
            varCloudTenantID.TabIndex = 36;
            varCloudTenantID.Text = "%CLDTEN_ID%";
            // 
            // AdminTools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 661);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(cmbIDPlatform);
            Controls.Add(label1);
            Controls.Add(lblHeader);
            Controls.Add(pictureBox1);
            DisplayHeader = false;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminTools";
            Padding = new Padding(20, 30, 20, 20);
            Style = MetroFramework.MetroColorStyle.Red;
            Text = "AdminTools";
            TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAzure).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cmbIDPlatform;
        private Label label5;
        private Panel panel1;
        private Label label2;
        private PictureBox btnAzure;
        private Label label4;
        private Label varCloudAppID;
        private Label varCloudTenantID;
    }
}