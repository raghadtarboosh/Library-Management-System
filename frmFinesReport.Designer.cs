namespace LibraryManagementSystem
{
    partial class frmFinesReport
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
            this.dgvFines = new System.Windows.Forms.DataGridView();
            this.lblTotalFines = new System.Windows.Forms.Label();
            this.btnPayFine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFines
            // 
            this.dgvFines.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFines.Location = new System.Drawing.Point(153, 64);
            this.dgvFines.Name = "dgvFines";
            this.dgvFines.RowHeadersWidth = 51;
            this.dgvFines.RowTemplate.Height = 26;
            this.dgvFines.Size = new System.Drawing.Size(461, 204);
            this.dgvFines.TabIndex = 0;
            // 
            // lblTotalFines
            // 
            this.lblTotalFines.AutoSize = true;
            this.lblTotalFines.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalFines.Location = new System.Drawing.Point(317, 24);
            this.lblTotalFines.Name = "lblTotalFines";
            this.lblTotalFines.Size = new System.Drawing.Size(146, 28);
            this.lblTotalFines.TabIndex = 1;
            this.lblTotalFines.Text = "إجمالي الغرامات";
            this.lblTotalFines.Click += new System.EventHandler(this.lblTotalFines_Click);
            // 
            // btnPayFine
            // 
            this.btnPayFine.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPayFine.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPayFine.ForeColor = System.Drawing.Color.White;
            this.btnPayFine.Location = new System.Drawing.Point(293, 309);
            this.btnPayFine.Name = "btnPayFine";
            this.btnPayFine.Size = new System.Drawing.Size(158, 53);
            this.btnPayFine.TabIndex = 2;
            this.btnPayFine.Text = "دفع الغرامة";
            this.btnPayFine.UseVisualStyleBackColor = false;
            this.btnPayFine.Click += new System.EventHandler(this.btnPayFine_Click);
            // 
            // frmFinesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPayFine);
            this.Controls.Add(this.lblTotalFines);
            this.Controls.Add(this.dgvFines);
            this.Name = "frmFinesReport";
            this.Text = "frmFinesReport";
            this.Load += new System.EventHandler(this.frmFinesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFines;
        private System.Windows.Forms.Label lblTotalFines;
        private System.Windows.Forms.Button btnPayFine;
    }
}