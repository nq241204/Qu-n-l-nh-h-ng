namespace RestaurantManagement
{
    partial class TableBookingForm
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
            this.btnViewMenu = new System.Windows.Forms.Button();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewMenu
            // 
            this.btnViewMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewMenu.Location = new System.Drawing.Point(49, 213);
            this.btnViewMenu.Name = "btnViewMenu";
            this.btnViewMenu.Size = new System.Drawing.Size(76, 40);
            this.btnViewMenu.TabIndex = 14;
            this.btnViewMenu.Text = "Close";
            this.btnViewMenu.UseVisualStyleBackColor = false;
            this.btnViewMenu.Click += new System.EventHandler(this.btnViewMenu_Click);
            // 
            // dgvTables
            // 
            this.dgvTables.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Location = new System.Drawing.Point(174, 76);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.Size = new System.Drawing.Size(441, 277);
            this.dgvTables.TabIndex = 13;
            this.dgvTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(295, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Table Booking";
            // 
            // btnBookTable
            // 
            this.btnBookTable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBookTable.Location = new System.Drawing.Point(49, 147);
            this.btnBookTable.Name = "btnBookTable";
            this.btnBookTable.Size = new System.Drawing.Size(76, 40);
            this.btnBookTable.TabIndex = 15;
            this.btnBookTable.Text = "Đặt bàn";
            this.btnBookTable.UseVisualStyleBackColor = false;
            this.btnBookTable.Click += new System.EventHandler(this.btnBookTable_Click);
            // 
            // TableBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestaurantManagement.Properties.Resources.ảnh_phụ;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBookTable);
            this.Controls.Add(this.btnViewMenu);
            this.Controls.Add(this.dgvTables);
            this.Controls.Add(this.label1);
            this.Name = "TableBookingForm";
            this.Text = "TableBookingForm";
            this.Load += new System.EventHandler(this.TableBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewMenu;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookTable;
    }
}