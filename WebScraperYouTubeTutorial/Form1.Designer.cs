namespace WebScraperYouTubeTutorial
{
    partial class Form1
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
            this.LabelURL = new System.Windows.Forms.Label();
            this.TextBoxURL = new System.Windows.Forms.TextBox();
            this.ButtonScrape = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelURL
            // 
            this.LabelURL.AutoSize = true;
            this.LabelURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelURL.Location = new System.Drawing.Point(101, 37);
            this.LabelURL.Name = "LabelURL";
            this.LabelURL.Size = new System.Drawing.Size(66, 26);
            this.LabelURL.TabIndex = 0;
            this.LabelURL.Text = "URL:";
            // 
            // TextBoxURL
            // 
            this.TextBoxURL.Location = new System.Drawing.Point(12, 112);
            this.TextBoxURL.Name = "TextBoxURL";
            this.TextBoxURL.Size = new System.Drawing.Size(260, 20);
            this.TextBoxURL.TabIndex = 3;
            // 
            // ButtonScrape
            // 
            this.ButtonScrape.Location = new System.Drawing.Point(67, 183);
            this.ButtonScrape.Name = "ButtonScrape";
            this.ButtonScrape.Size = new System.Drawing.Size(141, 42);
            this.ButtonScrape.TabIndex = 2;
            this.ButtonScrape.Text = "Scrape";
            this.ButtonScrape.UseVisualStyleBackColor = true;
            this.ButtonScrape.Click += new System.EventHandler(this.ButtonScrape_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ButtonScrape);
            this.Controls.Add(this.TextBoxURL);
            this.Controls.Add(this.LabelURL);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelURL;
        private System.Windows.Forms.TextBox TextBoxURL;
        private System.Windows.Forms.Button ButtonScrape;



    }
}

