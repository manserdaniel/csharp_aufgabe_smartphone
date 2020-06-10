namespace Smartphone
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lboxApps = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lboxStartedApps = new System.Windows.Forms.ListBox();
            this.lbAppsOnPhone = new System.Windows.Forms.Label();
            this.lbStartedApps = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lboxApps
            // 
            this.lboxApps.FormattingEnabled = true;
            this.lboxApps.ItemHeight = 20;
            this.lboxApps.Location = new System.Drawing.Point(41, 102);
            this.lboxApps.Name = "lboxApps";
            this.lboxApps.Size = new System.Drawing.Size(333, 204);
            this.lboxApps.TabIndex = 0;
            this.lboxApps.SelectedIndexChanged += new System.EventHandler(this.lboxApps_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStart.Location = new System.Drawing.Point(407, 49);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start: <App>";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lboxStartedApps
            // 
            this.lboxStartedApps.FormattingEnabled = true;
            this.lboxStartedApps.ItemHeight = 20;
            this.lboxStartedApps.Location = new System.Drawing.Point(407, 234);
            this.lboxStartedApps.Name = "lboxStartedApps";
            this.lboxStartedApps.Size = new System.Drawing.Size(333, 204);
            this.lboxStartedApps.TabIndex = 2;
            // 
            // lbAppsOnPhone
            // 
            this.lbAppsOnPhone.AutoSize = true;
            this.lbAppsOnPhone.Location = new System.Drawing.Point(37, 20);
            this.lbAppsOnPhone.Name = "lbAppsOnPhone";
            this.lbAppsOnPhone.Size = new System.Drawing.Size(221, 20);
            this.lbAppsOnPhone.TabIndex = 3;
            this.lbAppsOnPhone.Text = "Apps auf deinem Smartphone";
            // 
            // lbStartedApps
            // 
            this.lbStartedApps.AutoSize = true;
            this.lbStartedApps.Location = new System.Drawing.Point(403, 211);
            this.lbStartedApps.Name = "lbStartedApps";
            this.lbStartedApps.Size = new System.Drawing.Size(123, 20);
            this.lbStartedApps.TabIndex = 4;
            this.lbStartedApps.Text = "Geöffnete Apps";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(41, 56);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(217, 28);
            this.cbFilter.TabIndex = 5;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lbStartedApps);
            this.Controls.Add(this.lbAppsOnPhone);
            this.Controls.Add(this.lboxStartedApps);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lboxApps);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxApps;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lboxStartedApps;
        private System.Windows.Forms.Label lbAppsOnPhone;
        private System.Windows.Forms.Label lbStartedApps;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}

