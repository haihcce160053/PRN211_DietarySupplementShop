namespace DietarySupplementalShop
{
    partial class frmOrderCRUD
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
            label2 = new System.Windows.Forms.Label();
            txtOrderID = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtTotalBill = new System.Windows.Forms.TextBox();
            txtProductID = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            txtQuantity = new System.Windows.Forms.TextBox();
            dateTimeOrder = new System.Windows.Forms.DateTimePicker();
            btnProcess = new System.Windows.Forms.Button();
            cbOrderStatus = new System.Windows.Forms.ComboBox();
            txtTotalQuantity = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 15);
            label2.TabIndex = 20;
            label2.Text = "Order ID:";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new System.Drawing.Point(119, 22);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new System.Drawing.Size(283, 23);
            txtOrderID.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 22;
            label1.Text = "Order Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 187);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 26;
            label3.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(119, 184);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(283, 23);
            txtAddress.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(21, 148);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 15);
            label4.TabIndex = 24;
            label4.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(119, 145);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new System.Drawing.Size(283, 23);
            txtUsername.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(21, 225);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 15);
            label5.TabIndex = 28;
            label5.Text = "Order time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(21, 299);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 15);
            label6.TabIndex = 30;
            label6.Text = "Total bill:";
            // 
            // txtTotalBill
            // 
            txtTotalBill.Location = new System.Drawing.Point(119, 296);
            txtTotalBill.Name = "txtTotalBill";
            txtTotalBill.ReadOnly = true;
            txtTotalBill.Size = new System.Drawing.Size(283, 23);
            txtTotalBill.TabIndex = 29;
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(119, 103);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new System.Drawing.Size(283, 23);
            txtProductID.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(21, 106);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(66, 15);
            label7.TabIndex = 32;
            label7.Text = "Product ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(21, 260);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(56, 15);
            label8.TabIndex = 33;
            label8.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(119, 257);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new System.Drawing.Size(228, 23);
            txtQuantity.TabIndex = 34;
            // 
            // dateTimeOrder
            // 
            dateTimeOrder.Location = new System.Drawing.Point(119, 219);
            dateTimeOrder.Name = "dateTimeOrder";
            dateTimeOrder.Size = new System.Drawing.Size(283, 23);
            dateTimeOrder.TabIndex = 35;
            // 
            // btnProcess
            // 
            btnProcess.Location = new System.Drawing.Point(119, 341);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new System.Drawing.Size(283, 38);
            btnProcess.TabIndex = 36;
            btnProcess.Text = "Update/Delete";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // cbOrderStatus
            // 
            cbOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbOrderStatus.FormattingEnabled = true;
            cbOrderStatus.Items.AddRange(new object[] { "DCK", "DHD", "DLH", "DNH", "DVC", "DXN", "KLHD", "KNH" });
            cbOrderStatus.Location = new System.Drawing.Point(119, 61);
            cbOrderStatus.Name = "cbOrderStatus";
            cbOrderStatus.Size = new System.Drawing.Size(283, 23);
            cbOrderStatus.TabIndex = 37;
            // 
            // txtTotalQuantity
            // 
            txtTotalQuantity.Location = new System.Drawing.Point(353, 257);
            txtTotalQuantity.Name = "txtTotalQuantity";
            txtTotalQuantity.ReadOnly = true;
            txtTotalQuantity.Size = new System.Drawing.Size(49, 23);
            txtTotalQuantity.TabIndex = 38;
            // 
            // frmOrderCRUD
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(427, 403);
            Controls.Add(txtTotalQuantity);
            Controls.Add(cbOrderStatus);
            Controls.Add(btnProcess);
            Controls.Add(dateTimeOrder);
            Controls.Add(txtQuantity);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtProductID);
            Controls.Add(label6);
            Controls.Add(txtTotalBill);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtOrderID);
            Name = "frmOrderCRUD";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmOrderCRUD";
            Load += frmOrderCRUD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dateTimeOrder;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ComboBox cbOrderStatus;
        private System.Windows.Forms.TextBox txtTotalQuantity;
    }
}