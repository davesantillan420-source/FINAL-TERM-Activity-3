namespace LoginRegisterApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitle.Location = new System.Drawing.Point(30, 32);
            this.lblTitle.Text = "Welcome Back";

            // lblSub
            this.lblSub.Name = "lblSub";
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSub.Location = new System.Drawing.Point(34, 84);
            this.lblSub.Text = "Login to your account";

            // lblUser
            this.lblUser.Name = "lblUser";
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(167, 139, 250);
            this.lblUser.Location = new System.Drawing.Point(33, 140);
            this.lblUser.Text = "USERNAME";

            // txtUsername
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.Location = new System.Drawing.Point(36, 165);
            this.txtUsername.Size = new System.Drawing.Size(328, 29);
            this.txtUsername.TabIndex = 0;

            // lblPass
            this.lblPass.Name = "lblPass";
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(167, 139, 250);
            this.lblPass.Location = new System.Drawing.Point(33, 215);
            this.lblPass.Text = "PASSWORD";

            // txtPassword
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(36, 240);
            this.txtPassword.Size = new System.Drawing.Size(328, 29);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;

            // chkShow
            this.chkShow.Name = "chkShow";
            this.chkShow.AutoSize = true;
            this.chkShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShow.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.chkShow.Location = new System.Drawing.Point(36, 285);
            this.chkShow.TabIndex = 2;
            this.chkShow.Text = "Show password";
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);

            // btnLogin
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(139, 92, 246);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLogin.Location = new System.Drawing.Point(36, 330);
            this.btnLogin.Size = new System.Drawing.Size(328, 48);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // lblNoAccount
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNoAccount.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblNoAccount.Location = new System.Drawing.Point(70, 412);
            this.lblNoAccount.Text = "Don't have an account?";

            // lnkRegister
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkRegister.LinkColor = System.Drawing.Color.FromArgb(167, 139, 250);
            this.lnkRegister.Location = new System.Drawing.Point(232, 412);
            this.lnkRegister.TabIndex = 4;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Register";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);

            // pnlCard
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Location = new System.Drawing.Point(40, 40);
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlCard.Size = new System.Drawing.Size(400, 480);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblSub);
            this.pnlCard.Controls.Add(this.lblUser);
            this.pnlCard.Controls.Add(this.txtUsername);
            this.pnlCard.Controls.Add(this.lblPass);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.chkShow);
            this.pnlCard.Controls.Add(this.btnLogin);
            this.pnlCard.Controls.Add(this.lblNoAccount);
            this.pnlCard.Controls.Add(this.lnkRegister);

            // LoginForm
            this.AcceptButton = this.btnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(480, 560);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Name = "LoginForm";
            this.Controls.Add(this.pnlCard);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Panel pnlCard;
    }
}
