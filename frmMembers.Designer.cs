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
            this.grpInputMembers.Controls.Add(this.lblEmail);
            this.grpInputMembers.Controls.Add(this.txtEmail);
            this.grpInputMembers.Controls.Add(this.lblContact);
            this.grpInputMembers.Controls.Add(this.txtContactNumber);
            this.grpInputMembers.Controls.Add(this.txtFullName);
            this.grpInputMembers.Controls.Add(this.lblFullName);
            this.grpInputMembers.Location = new System.Drawing.Point(488, 12);
            this.grpInputMembers.Name = "grpInputMembers";
            this.grpInputMembers.Size = new System.Drawing.Size(300, 226);
            this.grpInputMembers.TabIndex = 0;
            this.grpInputMembers.TabStop = false;
            this.grpInputMembers.Text = "بيانات العضو";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(183, 168);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(123, 19);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = ":البريد الإلكتروني";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(28, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(144, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(193, 100);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(89, 19);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = ":رقم الاتصال";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(28, 100);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(144, 27);
            this.txtContactNumber.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(28, 46);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(144, 27);
            this.txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(178, 46);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(104, 19);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = ":الاسم الكامل";
            // 
            // dgvMembers
            // 
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(419, 326);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersWidth = 62;
            this.dgvMembers.RowTemplate.Height = 29;
            this.dgvMembers.Size = new System.Drawing.Size(240, 115);
            this.dgvMembers.TabIndex = 1;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(695, 259);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(93, 42);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "إضافة عضو";
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(576, 259);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(98, 42);
            this.btnUpdateMember.TabIndex = 3;
            this.btnUpdateMember.Text = "تعديل عضو";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(441, 259);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(98, 42);
            this.btnDeleteMember.TabIndex = 4;
            this.btnDeleteMember.Text = "حذف عضو";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 480);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnUpdateMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.grpInputMembers);
            this.Name = "frmMembers";
            this.Text = " ";
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