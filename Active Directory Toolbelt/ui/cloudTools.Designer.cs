namespace Active_Directory_Toolbelt.ui
{
    partial class CloudTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloudTools));
            lblHeader = new Label();
            btnReturn = new Button();
            pnlInfoSection = new Panel();
            btnAzure = new PictureBox();
            varIsDisabled = new Label();
            label9 = new Label();
            lblAccStatus = new Label();
            panel1 = new Panel();
            label1 = new Label();
            btnGCP = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnAWS = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            btnIBM = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            BtnExit = new Button();
            pnlInfoSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAzure).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnGCP).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAWS).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnIBM).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.FlatStyle = FlatStyle.Flat;
            lblHeader.Font = new Font("MV Boli", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = SystemColors.ButtonHighlight;
            lblHeader.Location = new Point(615, 105);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(90, 39);
            lblHeader.TabIndex = 26;
            lblHeader.Text = "Tools";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.DodgerBlue;
            btnReturn.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturn.ForeColor = SystemColors.ControlLightLight;
            btnReturn.Location = new Point(760, 33);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(177, 36);
            btnReturn.TabIndex = 27;
            btnReturn.Text = "<< Main Menu";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += BtnReturn_Click;
            // 
            // pnlInfoSection
            // 
            pnlInfoSection.BackColor = Color.FromArgb(19, 19, 19);
            pnlInfoSection.Controls.Add(btnAzure);
            pnlInfoSection.Controls.Add(varIsDisabled);
            pnlInfoSection.Controls.Add(label9);
            pnlInfoSection.Controls.Add(lblAccStatus);
            pnlInfoSection.Location = new Point(23, 159);
            pnlInfoSection.Name = "pnlInfoSection";
            pnlInfoSection.Size = new Size(396, 232);
            pnlInfoSection.TabIndex = 29;
            // 
            // btnAzure
            // 
            btnAzure.Image = (Image)resources.GetObject("btnAzure.Image");
            btnAzure.Location = new Point(69, 3);
            btnAzure.Name = "btnAzure";
            btnAzure.Size = new Size(244, 158);
            btnAzure.SizeMode = PictureBoxSizeMode.Zoom;
            btnAzure.TabIndex = 32;
            btnAzure.TabStop = false;
            btnAzure.Click += BtnAzure_Click;
            // 
            // varIsDisabled
            // 
            varIsDisabled.AutoSize = true;
            varIsDisabled.BackColor = Color.Transparent;
            varIsDisabled.FlatStyle = FlatStyle.Flat;
            varIsDisabled.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            varIsDisabled.ForeColor = Color.Red;
            varIsDisabled.Location = new Point(116, 208);
            varIsDisabled.Name = "varIsDisabled";
            varIsDisabled.Size = new Size(143, 13);
            varIsDisabled.TabIndex = 28;
            varIsDisabled.Text = "%IS_DISCONNECTED%";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(2, 164);
            label9.Name = "label9";
            label9.Size = new Size(391, 13);
            label9.TabIndex = 23;
            label9.Text = "________________________________________________";
            // 
            // lblAccStatus
            // 
            lblAccStatus.AutoSize = true;
            lblAccStatus.BackColor = Color.Transparent;
            lblAccStatus.FlatStyle = FlatStyle.Flat;
            lblAccStatus.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccStatus.ForeColor = Color.White;
            lblAccStatus.Location = new Point(127, 186);
            lblAccStatus.Name = "lblAccStatus";
            lblAccStatus.Size = new Size(124, 13);
            lblAccStatus.TabIndex = 20;
            lblAccStatus.Text = "Portal Status";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 19, 19);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGCP);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(501, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 232);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(128, 208);
            label1.Name = "label1";
            label1.Size = new Size(143, 13);
            label1.TabIndex = 34;
            label1.Text = "%IS_DISCONNECTED%";
            // 
            // btnGCP
            // 
            btnGCP.Image = (Image)resources.GetObject("btnGCP.Image");
            btnGCP.Location = new Point(88, 3);
            btnGCP.Name = "btnGCP";
            btnGCP.Size = new Size(244, 158);
            btnGCP.SizeMode = PictureBoxSizeMode.Zoom;
            btnGCP.TabIndex = 33;
            btnGCP.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 164);
            label2.Name = "label2";
            label2.Size = new Size(391, 13);
            label2.TabIndex = 23;
            label2.Text = "________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(145, 186);
            label3.Name = "label3";
            label3.Size = new Size(124, 13);
            label3.TabIndex = 20;
            label3.Text = "Portal Status";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(19, 19, 19);
            panel2.Controls.Add(btnAWS);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(23, 396);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 232);
            panel2.TabIndex = 31;
            // 
            // btnAWS
            // 
            btnAWS.Image = (Image)resources.GetObject("btnAWS.Image");
            btnAWS.Location = new Point(68, 3);
            btnAWS.Name = "btnAWS";
            btnAWS.Size = new Size(244, 158);
            btnAWS.SizeMode = PictureBoxSizeMode.Zoom;
            btnAWS.TabIndex = 35;
            btnAWS.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(113, 211);
            label4.Name = "label4";
            label4.Size = new Size(143, 13);
            label4.TabIndex = 29;
            label4.Text = "%IS_DISCONNECTED%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(2, 164);
            label5.Name = "label5";
            label5.Size = new Size(391, 13);
            label5.TabIndex = 23;
            label5.Text = "________________________________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(127, 186);
            label6.Name = "label6";
            label6.Size = new Size(124, 13);
            label6.TabIndex = 20;
            label6.Text = "Portal Status";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(19, 19, 19);
            panel3.Controls.Add(btnIBM);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(504, 399);
            panel3.Name = "panel3";
            panel3.Size = new Size(396, 232);
            panel3.TabIndex = 32;
            // 
            // btnIBM
            // 
            btnIBM.Image = (Image)resources.GetObject("btnIBM.Image");
            btnIBM.Location = new Point(0, 0);
            btnIBM.Name = "btnIBM";
            btnIBM.Size = new Size(396, 161);
            btnIBM.SizeMode = PictureBoxSizeMode.Zoom;
            btnIBM.TabIndex = 35;
            btnIBM.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(113, 211);
            label7.Name = "label7";
            label7.Size = new Size(143, 13);
            label7.TabIndex = 29;
            label7.Text = "%IS_DISCONNECTED%";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(2, 164);
            label8.Name = "label8";
            label8.Size = new Size(391, 13);
            label8.TabIndex = 23;
            label8.Text = "________________________________________________";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(127, 186);
            label10.Name = "label10";
            label10.Size = new Size(124, 13);
            label10.TabIndex = 20;
            label10.Text = "Portal Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("MV Boli", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(245, 28);
            label11.Name = "label11";
            label11.Size = new Size(234, 39);
            label11.TabIndex = 33;
            label11.Text = "Cloud Platform";
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Navy;
            BtnExit.FlatAppearance.MouseDownBackColor = Color.Blue;
            BtnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.ForeColor = SystemColors.ControlLightLight;
            BtnExit.Location = new Point(25, 28);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(27, 36);
            BtnExit.TabIndex = 36;
            BtnExit.Text = "X";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // CloudTools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 651);
            Controls.Add(BtnExit);
            Controls.Add(label11);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlInfoSection);
            Controls.Add(lblHeader);
            Controls.Add(btnReturn);
            DisplayHeader = false;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CloudTools";
            Padding = new Padding(20, 30, 20, 20);
            Style = MetroFramework.MetroColorStyle.Orange;
            Text = "CloudTools";
            Theme = MetroFramework.MetroThemeStyle.Dark;
            pnlInfoSection.ResumeLayout(false);
            pnlInfoSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAzure).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnGCP).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAWS).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnIBM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnReturn;
        private Panel pnlInfoSection;
        private Label varIsDisabled;
        private Label label9;
        private Label lblAccStatus;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private PictureBox btnAzure;
        private Label label1;
        private PictureBox btnGCP;
        private Label label4;
        private PictureBox btnAWS;
        private Panel panel3;
        private PictureBox btnIBM;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Button BtnExit;
    }
}