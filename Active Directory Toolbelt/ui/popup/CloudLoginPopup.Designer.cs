namespace Active_Directory_Toolbelt.ui.popup
{
    partial class CloudLoginPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloudLoginPopup));
            varWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)varWebView).BeginInit();
            SuspendLayout();
            // 
            // varWebView
            // 
            varWebView.CreationProperties = null;
            varWebView.DefaultBackgroundColor = SystemColors.WindowText;
            varWebView.Location = new Point(0, 1);
            varWebView.Name = "varWebView";
            varWebView.Size = new Size(429, 636);
            varWebView.Source = new Uri(resources.GetString("varWebView.Source"), UriKind.Absolute);
            varWebView.TabIndex = 0;
            varWebView.ZoomFactor = 1D;
            // 
            // CloudLoginPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 660);
            Controls.Add(varWebView);
            DisplayHeader = false;
            Name = "CloudLoginPopup";
            Padding = new Padding(20, 30, 20, 20);
            Resizable = false;
            Style = MetroFramework.MetroColorStyle.Black;
            Text = "CloudLoginPopup";
            Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)varWebView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 varWebView;
    }
}