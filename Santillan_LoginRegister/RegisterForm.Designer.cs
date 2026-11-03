namespace LoginRegisterApp
{
    partial class RegisterForm
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
            this.lblFull = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitle.Location = new System.Drawing.Point(30, 28);
            this.lblTitle.Text = "Create Account";

            // lblSub
            this.lblSub.Name = "lblSub";
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSub.Location = new System.Drawing.Point(34, 78);
            this.lblSub.Text = "Fill in the details to register";

            // lblFull
            this.lblFull.Name = "lblFull";
            this.lblFull.AutoSize = true;
            this.lblFull.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFull.ForeColor = System.Drawing.Color.FromArgb(167, 139, 250);
            this.lblFull.Location = new System.Drawing.Point(33, 120);
            this.lblFull.Text = "FULL NAME";

            // txtFullName
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFullName.Location = new System.Drawing.Point(36, 144);
            this.txtFullName.Size = new System.Drawing.Size(328, 29);
            this.txtFullName.TabIndex = 0;

            // lblUser
            this.lblUser.Name = "lblUser";
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(167, 139, 250);
            this.lblUser.Location = new System.Drawing.Point(33, 186);
            this.lblUser.Text = "USERNAME";

            // txtUsername
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.Location = new System.Drawing.Point(36, 210);
            this.txtUsername.Size = new System.Drawing.Size(328, 29);
            this.txtUsername.TabIndex = 1;

            // lblEmail
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(167, 139, 250);
            this.lblEmail.Location = new System.Drawing.Point(33, 252);
            this.lblEmail.Text = "EMAIL";

            // txtEmail
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(36, 276);
            this.txtEmail.Size = new System.Drawing.Size(328, 29);
            this.txtEmail.TabIndex = 2;

            // lblPass
            this.lblPass.Name = "lblPass";
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(167, 139, 250);
            this.lblPass.Location = new System.Drawing.Point(33, 318);
            this.lblPass.Text = "PASSWORD";

            // txtPassword
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(36, 342);
            this.txtPassword.Size = new System.Drawing.Size(328, 29);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;

            // lblConfirm
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(167, 139, 250);
            this.lblConfirm.Location = new System.Drawing.Point(33, 384);
            this.lblConfirm.Text = "CONFIRM PASSWORD";

            // txtConfirm
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtConfirm.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirm.Location = new System.Drawing.Point(36, 408);
            this.txtConfirm.Size = new System.Drawing.Size(328, 29);
            this.txtConfirm.TabIndex = 4;
            this.txtConfirm.UseSystemPasswordChar = true;

            // btnRegister
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(139, 92, 246);
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRegister.Location = new System.Drawing.Point(36, 470);
            this.btnRegister.Size = new System.Drawing.Size(328, 48);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // lnkBack
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.AutoSize = true;
            this.lnkBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkBack.LinkColor = System.Drawing.Color.FromArgb(167, 139, 250);
            this.lnkBack.Location = new System.Drawing.Point(152, 535);
            this.lnkBack.TabIndex = 6;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Back to Login";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);

            // pnlCard
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Location = new System.Drawing.Point(40, 40);
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlCard.Size = new System.Drawing.Size(400, 580);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblSub);
            this.pnlCard.Controls.Add(this.lblFull);
            this.pnlCard.Controls.Add(this.txtFullName);
            this.pnlCard.Controls.Add(this.lblUser);
            this.pnlCard.Controls.Add(this.txtUsername);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.lblPass);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.lblConfirm);
            this.pnlCard.Controls.Add(this.txtConfirm);
            this.pnlCard.Controls.Add(this.btnRegister);
            this.pnlCard.Controls.Add(this.lnkBack);

            // RegisterForm
            this.AcceptButton = this.btnRegister;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(480, 660);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.Name = "RegisterForm";
            this.Controls.Add(this.pnlCard);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel lnkBack;
        private System.Windows.Forms.Panel pnlCard;
    }
}
