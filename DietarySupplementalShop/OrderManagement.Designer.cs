namespace DietarySupplementalShop
{
    partial class OrderManagement
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
            txtOrderTime = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnViewDetail = new System.Windows.Forms.Button();
            txtOrderStatusID = new System.Windows.Forms.TextBox();
            txtOrderID = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnRefresh = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtTotalBill = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtOrderTime
            // 
            txtOrderTime.Location = new System.Drawing.Point(124, 122);
            txtOrderTime.Name = "txtOrderTime";
            txtOrderTime.ReadOnly = true;
            txtOrderTime.Size = new System.Drawing.Size(189, 23);
            txtOrderTime.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(124, 90);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new System.Drawing.Size(189, 23);
            txtAddress.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 125);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Order time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(18, 93);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 15);
            label4.TabIndex = 5;
            label4.Text = "Address:";
            // 
            // btnViewDetail
            // 
            btnViewDetail.Location = new System.Drawing.Point(18, 27);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new System.Drawing.Size(496, 30);
            btnViewDetail.TabIndex = 4;
            btnViewDetail.Text = "View order detail";
            btnViewDetail.UseVisualStyleBackColor = true;
            btnViewDetail.Click += btnViewDetail_Click;
            // 
            // txtOrderStatusID
            // 
            txtOrderStatusID.Location = new System.Drawing.Point(124, 59);
            txtOrderStatusID.Name = "txtOrderStatusID";
            txtOrderStatusID.ReadOnly = true;
            txtOrderStatusID.Size = new System.Drawing.Size(189, 23);
            txtOrderStatusID.TabIndex = 3;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new System.Drawing.Point(124, 27);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new System.Drawing.Size(189, 23);
            txtOrderID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Order status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Order ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(871, 352);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new System.Drawing.Point(12, 235);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(877, 374);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order information list";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(18, 160);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(496, 30);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh order information list";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(18, 93);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(496, 30);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update order";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRefresh);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnViewDetail);
            groupBox3.Location = new System.Drawing.Point(356, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(533, 204);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Function";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTotalBill);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtOrderTime);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtOrderStatusID);
            groupBox1.Controls.Add(txtOrderID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(338, 204);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order information";
            // 
            // txtTotalBill
            // 
            txtTotalBill.Location = new System.Drawing.Point(124, 157);
            txtTotalBill.Name = "txtTotalBill";
            txtTotalBill.ReadOnly = true;
            txtTotalBill.Size = new System.Drawing.Size(189, 23);
            txtTotalBill.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(18, 160);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Totall bill:";
            // 
            // OrderManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(901, 621);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "OrderManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "OrderManagement";
            Load += OrderManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderTime;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.TextBox txtOrderStatusID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label5;
    }
}