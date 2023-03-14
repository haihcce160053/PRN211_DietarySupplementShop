namespace DietarySupplementalShop
{
    partial class frmMain
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
            btnAccountMng = new System.Windows.Forms.Button();
            btnProductMng = new System.Windows.Forms.Button();
            btnOrderMng = new System.Windows.Forms.Button();
            lblHello = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnAccountMng
            // 
            btnAccountMng.Location = new System.Drawing.Point(12, 43);
            btnAccountMng.Name = "btnAccountMng";
            btnAccountMng.Size = new System.Drawing.Size(389, 30);
            btnAccountMng.TabIndex = 0;
            btnAccountMng.Text = "Account management";
            btnAccountMng.UseVisualStyleBackColor = true;
            btnAccountMng.Click += btnAccountMng_Click;
            // 
            // btnProductMng
            // 
            btnProductMng.Location = new System.Drawing.Point(12, 79);
            btnProductMng.Name = "btnProductMng";
            btnProductMng.Size = new System.Drawing.Size(389, 30);
            btnProductMng.TabIndex = 1;
            btnProductMng.Text = "Product management";
            btnProductMng.UseVisualStyleBackColor = true;
            // 
            // btnOrderMng
            // 
            btnOrderMng.Location = new System.Drawing.Point(12, 115);
            btnOrderMng.Name = "btnOrderMng";
            btnOrderMng.Size = new System.Drawing.Size(389, 30);
            btnOrderMng.TabIndex = 2;
            btnOrderMng.Text = "Order management";
            btnOrderMng.UseVisualStyleBackColor = true;
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Location = new System.Drawing.Point(12, 13);
            lblHello.Name = "lblHello";
            lblHello.Size = new System.Drawing.Size(41, 15);
            lblHello.TabIndex = 3;
            lblHello.Text = "Hello, ";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(416, 160);
            Controls.Add(lblHello);
            Controls.Add(btnOrderMng);
            Controls.Add(btnProductMng);
            Controls.Add(btnAccountMng);
            Name = "frmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dietary Supplement Shop";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAccountMng;
        private System.Windows.Forms.Button btnProductMng;
        private System.Windows.Forms.Button btnOrderMng;
        private System.Windows.Forms.Label lblHello;
    }
}