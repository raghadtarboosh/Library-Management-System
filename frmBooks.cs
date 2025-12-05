using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmBooks : Form
    {
        // Lec 04: إغلاق الواجهة الحالية والعودة للدخول
        //    frmLogin loginForm = new frmLogin();
        //    loginForm.Show();
        //this.Close(); // إغلاق frmMain


        // 1. تعريف متغيرات الحالة والخدمة (في أعلى الفئة)
        private IBookService _bookService = new BookService();
        private int _selectedBookId = 0;

        // 2. المنشئ (Constructor) - يتم تشغيله عند إنشاء كائن النموذج
        public frmBooks()
        {
            InitializeComponent();
            // **المكان الأول للاستدعاء: داخل المنشئ**
            LoadBooksData();
        }

        // 3. الدالة المساعدة لعرض البيانات (LoadBooksData)
        private void LoadBooksData()
        {
            // Lec 07: ربط البيانات (Data Binding)
            var booksList = _bookService.GetAllBooks();
            dgvBooks.DataSource = booksList;
            // ضمان تحديث العرض في حالة الربط المعقد
            dgvBooks.Refresh();
        }


        private void lblAuthor_Click(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpInput_Enter(object sender, EventArgs e)
        {

        }

        // 4. معالج حدث زر الإضافة (Event Handler)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. إنشاء كائن Book جديد (Lec 5: Object Creation)
            Book newBook = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                ISBN = txtISBN.Text,
                // تحويل نوع البيانات من string إلى int (Lec 1: Type Casting)
                YearPublished = int.Parse(txtYear.Text),
                IsAvailable = true // افتراضياً متاح
            };

            // 2. استدعاء خدمة الإضافة (Lec 06: Service Layer)
            try
            {
                _bookService.AddBook(newBook);
                MessageBox.Show("تمت إضافة الكتاب بنجاح!");

                // 3. تحديث جدول العرض
                LoadBooksData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}");
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // التأكد أن النقر كان على صف فعلي وليس على رأس الجدول
            if (e.RowIndex >= 0)
            {
                // 1. استخراج الصف المحدد
                DataGridViewRow row = this.dgvBooks.Rows[e.RowIndex];

                // 2. تحديث متغير الحالة (Lec 01: Type Casting)
                // الحصول على قيمة BookId من الخلية الأولى وتحويلها إلى int
                _selectedBookId = (int)row.Cells["BookId"].Value;

                // 3. ملء مربعات النص ببيانات الكتاب (Lec 04: Controls Interaction)
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAuthor.Text = row.Cells["Author"].Value.ToString();
                txtISBN.Text = row.Cells["ISBN"].Value.ToString();
                txtYear.Text = row.Cells["YearPublished"].Value.ToString();

                // يمكن أيضاً تفعيل زر التعديل والحذف هنا
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedBookId == 0)
            {
                MessageBox.Show("يرجى اختيار كتاب لتعديله أولاً.");
                return;
            }

            // 1. إنشاء كائن Book جديد بالبيانات المحدثة (مع ID)
            Book updatedBook = new Book
            {
                BookId = _selectedBookId, // مهم جداً لتحديد الصف المراد تعديله
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                ISBN = txtISBN.Text,
                YearPublished = int.Parse(txtYear.Text),
                IsAvailable = true
            };

            // 2. استدعاء خدمة التعديل
            try
            {
                _bookService.UpdateBook(updatedBook);
                MessageBox.Show("تم تعديل الكتاب بنجاح!");

                // 3. تحديث جدول العرض ومسح الحقول
                LoadBooksData();
                ClearInputFields(); // دالة جديدة لسهولة الاستخدام
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ في التعديل: {ex.Message}");
            }

           
        } 

            // دالة مساعدة لعملية التنظيف
            private void ClearInputFields()
            {
                txtTitle.Clear();
                txtAuthor.Clear();
                txtISBN.Clear();
                txtYear.Clear();
                _selectedBookId = 0; // إعادة تعيين الـ ID المحدد
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedBookId == 0)
            {
                MessageBox.Show("يرجى اختيار كتاب لحذفه أولاً.");
                return;
            }

            // 1. طلب تأكيد الحذف من المستخدم
            DialogResult confirm = MessageBox.Show(
                "هل أنت متأكد من حذف هذا الكتاب؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                // 2. استدعاء خدمة الحذف
                try
                {
                    _bookService.DeleteBook(_selectedBookId);
                    MessageBox.Show("تم حذف الكتاب بنجاح!");

                    // 3. تحديث الجدول ومسح الحقول
                    LoadBooksData();
                    ClearInputFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ في الحذف: {ex.Message}");
                }
            }
        }
    }
    }

