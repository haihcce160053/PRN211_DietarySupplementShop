
namespace DietarySupplementalShop
{
    partial class frmLogin
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
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            lblHello = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(12, 68);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(283, 23);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Admin";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(12, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(283, 23);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Admin123";
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(12, 162);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(283, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(274, 25);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Login to management system";
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Location = new System.Drawing.Point(12, 45);
            lblHello.Name = "lblHello";
            lblHello.Size = new System.Drawing.Size(63, 15);
            lblHello.TabIndex = 5;
            lblHello.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 104);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "Password:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(312, 212);
            Controls.Add(label1);
            Controls.Add(lblHello);
            Controls.Add(lblTitle);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label label1;
    }
}