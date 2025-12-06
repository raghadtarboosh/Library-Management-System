namespace LibraryManagementSystem
{
    partial class frmBorrowing
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberContact = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookISBN = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.dgvAvailableBooks = new System.Windows.Forms.DataGridView();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvActiveBorrowings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveBorrowings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = ":رقم اتصال العضو";
            // 
            // txtMemberContact
            // 
            this.txtMemberContact.Location = new System.Drawing.Point(450, 27);
            this.txtMemberContact.Name = "txtMemberContact";
            this.txtMemberContact.Size = new System.Drawing.Size(100, 27);
            this.txtMemberContact.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(450, 60);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(100, 31);
            this.btnSearchMember.TabIndex = 3;
            this.btnSearchMember.Text = "بحث العضو";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = ":اسم العضو";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(724, 81);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(45, 19);
            this.lblMemberName.TabIndex = 5;
            this.lblMemberName.Text = "____";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "رقم ISBN للكتاب";
            // 
            // txtBookISBN
            // 
            this.txtBookISBN.Location = new System.Drawing.Point(450, 139);
            this.txtBookISBN.Name = "txtBookISBN";
            this.txtBookISBN.Size = new System.Drawing.Size(100, 27);
            this.txtBookISBN.TabIndex = 7;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(450, 184);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(98, 31);
            this.btnSearchBook.TabIndex = 8;
            this.btnSearchBook.Text = "بحث الكتاب";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = ":عنوان الكتاب";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(724, 196);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(45, 19);
            this.lblBookTitle.TabIndex = 10;
            this.lblBookTitle.Text = "____";
            // 
            // dgvAvailableBooks
            // 
            this.dgvAvailableBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableBooks.Location = new System.Drawing.Point(12, 12);
            this.dgvAvailableBooks.Name = "dgvAvailableBooks";
            this.dgvAvailableBooks.RowHeadersWidth = 62;
            this.dgvAvailableBooks.RowTemplate.Height = 29;
            this.dgvAvailableBooks.Size = new System.Drawing.Size(204, 414);
            this.dgvAvailableBooks.TabIndex = 11;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(628, 330);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(141, 46);
            this.btnBorrow.TabIndex = 12;
            this.btnBorrow.Text = "تسجيل الإعارة";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(467, 330);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(143, 46);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "تسجيل الإرجاع";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvActiveBorrowings
            // 
            this.dgvActiveBorrowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveBorrowings.Location = new System.Drawing.Point(222, 12);
            this.dgvActiveBorrowings.Name = "dgvActiveBorrowings";
            this.dgvActiveBorrowings.RowHeadersWidth = 62;
            this.dgvActiveBorrowings.RowTemplate.Height = 29;
            this.dgvActiveBorrowings.Size = new System.Drawing.Size(205, 414);
            this.dgvActiveBorrowings.TabIndex = 14;
            // 
            // frmBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvActiveBorrowings);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.dgvAvailableBooks);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.txtBookISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.txtMemberContact);
            this.Controls.Add(this.label1);
            this.Name = "frmBorrowing";
            this.Text = "عمليات الإعارة والإرجاع";
            this.Load += new System.EventHandler(this.frmBorrowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveBorrowings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberContact;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookISBN;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.DataGridView dgvAvailableBooks;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvActiveBorrowings;
    }
}