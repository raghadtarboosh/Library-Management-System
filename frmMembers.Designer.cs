namespace LibraryManagementSystem
{
    partial class frmMembers
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
            this.grpInputMembers = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.grpInputMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInputMembers
            // 
            this.grpInputMembers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpInputMembers.Controls.Add(this.lblEmail);
            this.grpInputMembers.Controls.Add(this.txtEmail);
            this.grpInputMembers.Controls.Add(this.lblContact);
            this.grpInputMembers.Controls.Add(this.txtContactNumber);
            this.grpInputMembers.Controls.Add(this.txtFullName);
            this.grpInputMembers.Controls.Add(this.lblFullName);
            this.grpInputMembers.Location = new System.Drawing.Point(320, 40);
            this.grpInputMembers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpInputMembers.Name = "grpInputMembers";
            this.grpInputMembers.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpInputMembers.Size = new System.Drawing.Size(336, 223);
            this.grpInputMembers.TabIndex = 0;
            this.grpInputMembers.TabStop = false;
            this.grpInputMembers.Text = "بيانات العضو";
            this.grpInputMembers.Enter += new System.EventHandler(this.grpInputMembers_Enter);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEmail.Location = new System.Drawing.Point(213, 156);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(128, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = ":البريد الإلكتروني";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(4, 158);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 24);
            this.txtEmail.TabIndex = 2;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblContact.Location = new System.Drawing.Point(236, 100);
            this.lblContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(96, 23);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = ":رقم الاتصال";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(4, 99);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(213, 24);
            this.txtContactNumber.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(4, 49);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(213, 24);
            this.txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFullName.Location = new System.Drawing.Point(236, 50);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(101, 23);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = ":الاسم الكامل";
            // 
            // dgvMembers
            // 
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMembers.Location = new System.Drawing.Point(2, 26);
            this.dgvMembers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersWidth = 62;
            this.dgvMembers.RowTemplate.Height = 29;
            this.dgvMembers.Size = new System.Drawing.Size(297, 284);
            this.dgvMembers.TabIndex = 1;
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.Location = new System.Drawing.Point(495, 347);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(152, 45);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "إضافة عضو";
            this.btnAddMember.UseVisualStyleBackColor = false;
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateMember.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdateMember.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMember.Location = new System.Drawing.Point(258, 347);
            this.btnUpdateMember.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(152, 45);
            this.btnUpdateMember.TabIndex = 3;
            this.btnUpdateMember.Text = "تعديل عضو";
            this.btnUpdateMember.UseVisualStyleBackColor = false;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteMember.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteMember.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMember.Location = new System.Drawing.Point(31, 347);
            this.btnDeleteMember.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(152, 45);
            this.btnDeleteMember.TabIndex = 4;
            this.btnDeleteMember.Text = "حذف عضو";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 404);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnUpdateMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.grpInputMembers);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMembers";
            this.Text = "Z";
            this.grpInputMembers.ResumeLayout(false);
            this.grpInputMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputMembers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnDeleteMember;
    }
}