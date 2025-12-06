using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Services; // يجب إضافتها
using LibraryManagementSystem.Models;   // يجب إضافتها
using System.Linq; // يجب إضافتها

namespace LibraryManagementSystem
{
    public partial class frmBorrowing : Form
    {
        private readonly IMemberService _memberService = new MemberService();
        private readonly IBookService _bookService = new BookService();
        private readonly IBorrowingService _borrowingService = new BorrowingService();

        private int _selectedMemberId = 0; // لحفظ ID العضو المحدد
        private int _selectedBookId = 0;   // لحفظ ID الكتاب المحدد
        public frmBorrowing()
        {
            InitializeComponent();
            LoadAvailableBooks();
            LoadActiveBorrowings(); // 📌 عند تحميل النموذج
        }

        private void frmBorrowing_Load(object sender, EventArgs e)
        {

        }
        private void ClearState()
        {
            // 1. مسح حقول البحث
            txtMemberContact.Clear();
            txtBookISBN.Clear();

            // 2. مسح العناوين
            lblMemberName.Text = "____";
            lblBookTitle.Text = "____";

            // 3. إعادة تعيين متغيرات الحالة (مهم جداً!)
            _selectedMemberId = 0;
            _selectedBookId = 0;

            // 4. تعطيل أزرار الإعارة إذا لزم الأمر
            btnBorrow.Enabled = false;
        }
        private void LoadAvailableBooks()
        {
            // 1. استخدام خدمة الكتب التي تم تعريفها في رأس الفئة (_bookService)
            var availableBooks = _bookService.GetAvailableBooks();

            // 2. ربط البيانات (Data Binding - Lec 7)
            dgvAvailableBooks.DataSource = availableBooks;

            // 3. (اختياري) إخفاء بعض الأعمدة غير الضرورية للعرض
            if (dgvAvailableBooks.Columns.Contains("Borrowings"))
            {
                dgvAvailableBooks.Columns["Borrowings"].Visible = false;
            }
        }
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            string contact = txtMemberContact.Text.Trim();

            // 1. استخدام خدمة الأعضاء للبحث
            var member = _memberService.GetMemberByContact(contact);

            if (member != null)
            {
                // 2. تحديث الحالة وعرض الاسم
                _selectedMemberId = member.MemberId;
                lblMemberName.Text = $"العضو المحدد: {member.FullName}";

                // 3. تفعيل الأزرار/القسم التالي
                // ... (يمكن تفعيل قسم اختيار الكتاب هنا)
                MessageBox.Show($"تم العثور على العضو: {member.FullName}");
            }
            else
            {
                _selectedMemberId = 0;
                lblMemberName.Text = "العضو المحدد: غير موجود";
                MessageBox.Show("لم يتم العثور على عضو بهذا الرقم.");
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            // 1. التحقق من اختيار عضو وكتاب
            if (_selectedMemberId == 0)
            {
                MessageBox.Show("يجب تحديد العضو أولاً.");
                return;
            }
            if (_selectedBookId == 0)
            {
                MessageBox.Show("يجب تحديد الكتاب أولاً.");
                return;
            }

            // حدد المدة المطلوبة (مثلاً 7 أيام)
            int days = 7;
            // 2. استدعاء خدمة الإعارة (Lec 06: Service Layer)
            bool success = _borrowingService.BorrowBook(_selectedMemberId, _selectedBookId, days);

            if (success)
            {
                MessageBox.Show("تمت عملية الإعارة بنجاح. يرجى التذكير بتاريخ الإرجاع.");
                // 3. إعادة تعيين الحالة وتحديث قائمة الكتب المتاحة
                ClearState(); // دالة مساعدة
                LoadAvailableBooks();
            }
            else
            {
                MessageBox.Show("فشلت عملية الإعارة. ربما الكتاب غير متاح أو البيانات غير صحيحة.");
            }
        }

        private void LoadActiveBorrowings()
        {
            // 1. جلب البيانات من طبقة الخدمة
            var activeBorrowings = _borrowingService.GetActiveBorrowings();

            // 2. ربط البيانات باستخدام LINQ Projection (Anonymous Type)
            // نستخدم التحديد (Select) لإنشاء كائنات جديدة تحتوي فقط على الحقول المراد عرضها،
            // بما في ذلك اسم العضو وعنوان الكتاب من خلال علاقاتهم.
            dgvActiveBorrowings.DataSource = activeBorrowings.Select(b => new
            {
                // نحتاج هذا المفتاح لتمريره لعملية الإرجاع
                b.BorrowingId,

                // عرض اسم العضو وعنوان الكتاب
                MemberName = b.Member.FullName,
                BookTitle = b.Book.Title,

                b.BorrowDate,
                b.DueDate // تاريخ الاستحقاق
            }).ToList();

            // 3. (اختياري) تأكد من ظهور الأعمدة بالعرض المناسب
            dgvActiveBorrowings.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // 1. التحقق من اختيار صف
            if (dgvActiveBorrowings.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار عملية إعارة للإرجاع أولاً.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. استخراج قيمة BorrowingId من الصف المحدد
            // يجب أن يكون اسم العمود هو "BorrowingId"
            int borrowingId = (int)dgvActiveBorrowings.SelectedRows[0].Cells["BorrowingId"].Value;

            // 3. استدعاء خدمة الإرجاع وتطبيق منطق النجاح والفشل
            if (_borrowingService.ReturnBook(borrowingId))
            {
                // 📌 هنا يتم وضع الكود المطلوب (منطق النجاح)
                MessageBox.Show("تم إرجاع الكتاب بنجاح. تحقق من وجود غرامات تأخير إن وجدت.", "نجاح الإرجاع", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadActiveBorrowings(); // تحديث القائمة لإزالة السجل المرجع
                LoadAvailableBooks();   // تحديث قائمة الكتب المتاحة لإضافة الكتاب المرجع إليها
            }
            else
            {
                // منطق الفشل
                MessageBox.Show("فشلت عملية الإرجاع. لم يتم العثور على السجل النشط.", "فشل الإرجاع", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
