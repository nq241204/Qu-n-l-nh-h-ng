namespace RestaurantManagement
{
    partial class UserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewMenu = new System.Windows.Forms.Button();
            this.btnBookTable = new System.Windows.Forms.Button();
            this.btnRequestBill = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(247, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnViewMenu
            // 
            this.btnViewMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewMenu.Location = new System.Drawing.Point(169, 137);
            this.btnViewMenu.Name = "btnViewMenu";
            this.btnViewMenu.Size = new System.Drawing.Size(76, 40);
            this.btnViewMenu.TabIndex = 10;
            this.btnViewMenu.Text = "Xem thực đơn";
            this.btnViewMenu.UseVisualStyleBackColor = false;
            this.btnViewMenu.Click += new System.EventHandler(this.btnViewMenu_Click);
            // 
            // btnBookTable
            // 
            this.btnBookTable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBookTable.Location = new System.Drawing.Point(295, 137);
            this.btnBookTable.Name = "btnBookTable";
            this.btnBookTable.Size = new System.Drawing.Size(76, 40);
            this.btnBookTable.TabIndex = 11;
            this.btnBookTable.Text = "Đặt bàn";
            this.btnBookTable.UseVisualStyleBackColor = false;
            this.btnBookTable.Click += new System.EventHandler(this.btnBookTable_Click);
            // 
            // btnRequestBill
            // 
            this.btnRequestBill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRequestBill.Location = new System.Drawing.Point(418, 137);
            this.btnRequestBill.Name = "btnRequestBill";
            this.btnRequestBill.Size = new System.Drawing.Size(76, 40);
            this.btnRequestBill.TabIndex = 12;
            this.btnRequestBill.Text = "Yêu cầu hóa đơn";
            this.btnRequestBill.UseVisualStyleBackColor = false;
            this.btnRequestBill.Click += new System.EventHandler(this.btnRequestBill_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Location = new System.Drawing.Point(539, 137);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(76, 40);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestaurantManagement.Properties.Resources.ảnh_phụ;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRequestBill);
            this.Controls.Add(this.btnBookTable);
            this.Controls.Add(this.btnViewMenu);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewMenu;
        private System.Windows.Forms.Button btnBookTable;
        private System.Windows.Forms.Button btnRequestBill;
        private System.Windows.Forms.Button btnLogout;
    }
}