namespace RestaurantManagement
{
    partial class BillManagementForm
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
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            this.btnRequestBill = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.cbMenuItems = new System.Windows.Forms.ComboBox();
            this.txtTotalAmount = new System.Windows.Forms.Label();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBillDetails
            // 
            this.dgvBillDetails.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetails.Location = new System.Drawing.Point(275, 37);
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.Size = new System.Drawing.Size(394, 245);
            this.dgvBillDetails.TabIndex = 18;
            // 
            // btnRequestBill
            // 
            this.btnRequestBill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRequestBill.Location = new System.Drawing.Point(15, 160);
            this.btnRequestBill.Name = "btnRequestBill";
            this.btnRequestBill.Size = new System.Drawing.Size(76, 40);
            this.btnRequestBill.TabIndex = 20;
            this.btnRequestBill.Text = "Thêm món";
            this.btnRequestBill.UseVisualStyleBackColor = false;
            this.btnRequestBill.Click += new System.EventHandler(this.btnRequestBill_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(97, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "Xóa món";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(179, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(7, 49);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(62, 21);
            this.cbTables.TabIndex = 23;
            this.cbTables.Text = "Bàn";
            // 
            // cbMenuItems
            // 
            this.cbMenuItems.FormattingEnabled = true;
            this.cbMenuItems.Location = new System.Drawing.Point(85, 49);
            this.cbMenuItems.Name = "cbMenuItems";
            this.cbMenuItems.Size = new System.Drawing.Size(151, 21);
            this.cbMenuItems.TabIndex = 24;
            this.cbMenuItems.Text = "Món ăn";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.AutoSize = true;
            this.txtTotalAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(3, 304);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(66, 16);
            this.txtTotalAmount.TabIndex = 25;
            this.txtTotalAmount.Text = "Tổng tiền:";
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculateTotal.Location = new System.Drawing.Point(85, 242);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(100, 40);
            this.btnCalculateTotal.TabIndex = 26;
            this.btnCalculateTotal.Text = "Tính tổng tiền";
            this.btnCalculateTotal.UseVisualStyleBackColor = false;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // BillManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestaurantManagement.Properties.Resources.ảnh_phụ;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculateTotal);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.cbMenuItems);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRequestBill);
            this.Controls.Add(this.dgvBillDetails);
            this.Name = "BillManagementForm";
            this.Text = "BillManagementForm";
            this.Load += new System.EventHandler(this.BillManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBillDetails;
        private System.Windows.Forms.Button btnRequestBill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.ComboBox cbMenuItems;
        private System.Windows.Forms.Label txtTotalAmount;
        private System.Windows.Forms.Button btnCalculateTotal;
    }
}