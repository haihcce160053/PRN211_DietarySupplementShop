namespace DietarySupplementalShop
{
    partial class ProductManagement
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
            groupBox3 = new System.Windows.Forms.GroupBox();
            btnRefresh = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtDescription = new System.Windows.Forms.TextBox();
            txtPictureLink = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnViewDetail = new System.Windows.Forms.Button();
            txtProductName = new System.Windows.Forms.TextBox();
            txtProductID = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRefresh);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Location = new System.Drawing.Point(356, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(533, 204);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Function";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(18, 160);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(496, 30);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh product information list";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = System.Drawing.Color.Red;
            btnDelete.Location = new System.Drawing.Point(18, 118);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(496, 30);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete product";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(18, 72);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(496, 30);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update product";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(18, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(496, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add new product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new System.Drawing.Point(12, 235);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(877, 374);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product information list";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtPictureLink);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnViewDetail);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(338, 204);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product information";
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(124, 122);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new System.Drawing.Size(189, 23);
            txtDescription.TabIndex = 8;
            // 
            // txtPictureLink
            // 
            txtPictureLink.Location = new System.Drawing.Point(124, 90);
            txtPictureLink.Name = "txtPictureLink";
            txtPictureLink.ReadOnly = true;
            txtPictureLink.Size = new System.Drawing.Size(189, 23);
            txtPictureLink.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 125);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 15);
            label3.TabIndex = 6;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(18, 93);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 15);
            label4.TabIndex = 5;
            label4.Text = "Picture link:";
            // 
            // btnViewDetail
            // 
            btnViewDetail.Location = new System.Drawing.Point(18, 160);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new System.Drawing.Size(295, 30);
            btnViewDetail.TabIndex = 4;
            btnViewDetail.Text = "View product detail";
            btnViewDetail.UseVisualStyleBackColor = true;
            btnViewDetail.Click += btnViewDetail_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(124, 59);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new System.Drawing.Size(189, 23);
            txtProductName.TabIndex = 3;
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(124, 27);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new System.Drawing.Size(189, 23);
            txtProductID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Product name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Product ID:";
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(901, 621);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ProductManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Product Management";
            Load += ProductManagement_Load;
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPictureLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}