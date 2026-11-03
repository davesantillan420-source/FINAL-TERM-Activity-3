namespace LoginRegisterApp
{
    partial class WelcomeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblWelcome
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlAccent
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(139, 92, 246);
            this.pnlAccent.Size = new System.Drawing.Size(800, 6);

            // btnLogout
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(139, 92, 246);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLogout.Location = new System.Drawing.Point(345, 350);
            this.btnLogout.Size = new System.Drawing.Size(110, 42);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // WelcomeForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Name = "WelcomeForm";
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlAccent);
            this.Controls.Add(this.lblWelcome);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Button btnLogout;
    }
}
