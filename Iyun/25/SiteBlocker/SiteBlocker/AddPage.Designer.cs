namespace SiteBlocker
{
    partial class AddPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPage));
            this.addPageAddButton = new System.Windows.Forms.Button();
            this.addPageSiteTextBox = new System.Windows.Forms.TextBox();
            this.siteNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addPageAddButton
            // 
            this.addPageAddButton.Location = new System.Drawing.Point(386, 21);
            this.addPageAddButton.Name = "addPageAddButton";
            this.addPageAddButton.Size = new System.Drawing.Size(75, 23);
            this.addPageAddButton.TabIndex = 1;
            this.addPageAddButton.Text = "Add";
            this.addPageAddButton.UseVisualStyleBackColor = true;
            this.addPageAddButton.Click += new System.EventHandler(this.addPageAddButton_Click);
            // 
            // addPageSiteTextBox
            // 
            this.addPageSiteTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.addPageSiteTextBox.ForeColor = System.Drawing.Color.Red;
            this.addPageSiteTextBox.Location = new System.Drawing.Point(96, 21);
            this.addPageSiteTextBox.Name = "addPageSiteTextBox";
            this.addPageSiteTextBox.Size = new System.Drawing.Size(250, 20);
            this.addPageSiteTextBox.TabIndex = 0;
            // 
            // siteNameLabel
            // 
            this.siteNameLabel.AutoSize = true;
            this.siteNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.siteNameLabel.Location = new System.Drawing.Point(12, 21);
            this.siteNameLabel.Name = "siteNameLabel";
            this.siteNameLabel.Size = new System.Drawing.Size(81, 15);
            this.siteNameLabel.TabIndex = 2;
            this.siteNameLabel.Text = "Enter the site:";
            // 
            // AddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(474, 67);
            this.Controls.Add(this.siteNameLabel);
            this.Controls.Add(this.addPageSiteTextBox);
            this.Controls.Add(this.addPageAddButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPageAddButton;
        private System.Windows.Forms.TextBox addPageSiteTextBox;
        private System.Windows.Forms.Label siteNameLabel;
    }
}