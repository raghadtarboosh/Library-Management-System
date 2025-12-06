using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;



namespace LibraryManagementSystem
{
    public partial class frmFinesReport : Form
    {
        public frmFinesReport()
        {
            InitializeComponent();
        }

        private void frmFinesReport_Load(object sender, EventArgs e)
        {

        }
        private IFineService _fineService = new FineService();

        private void LoadFinesReport()
        {
            var unpaidFines = _fineService.GetUnpaidFines();
            dgvFines.DataSource = unpaidFines.Select(f => new
            {
                f.FineId,
                MemberName = f.Borrowing.Member.FullName, // عرض اسم العضو من خلال العلاقة
                f.Amount,
                f.FineDate
            }).ToList();

            // حساب الإجمالي
            decimal total = unpaidFines.Sum(f => f.Amount); // LINQ: استخدام دالة Sum
            lblTotalFines.Text = $"إجمالي الغرامات غير المدفوعة: {total:C} ريال";
        }

        private void btnPayFine_Click(object sender, EventArgs e)
        {
            // Lec 04: التحقق من وجود صف محدد في الـ DataGridView
            if (dgvFines.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار الغرامة المراد دفعها أولاً.");
                return;
            }

            // 1. الحصول على الصف المحدد (يفترض أن العرض يسمح بتحديد صف واحد)
            DataGridViewRow selectedRow = dgvFines.SelectedRows[0];

            // 2. الحصول على قيمة FineId من الخلية. يجب استخدام اسم العمود (FineId)
            // Lec 01: يجب أن نتحقق من عدم كون القيمة فارغة (null) وأن يتم تحويلها إلى int
            if (selectedRow.Cells["FineId"].Value == null)
            {
                MessageBox.Show("خطأ: لم يتم العثور على معرف الغرامة.");
                return;
            }

            // Lec 01: تحويل القيمة المستخرجة إلى نوع int
            int fineId = (int)selectedRow.Cells["FineId"].Value;

            // 3. تأكيد عملية الدفع
            DialogResult confirm = MessageBox.Show(
                $"هل أنت متأكد من تسجيل دفع الغرامة رقم {fineId}؟",
                "تأكيد الدفع",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // 4. استدعاء خدمة الدفع
                try
                {
                    _fineService.PayFine(fineId);
                    MessageBox.Show("تم تسجيل عملية الدفع بنجاح.");

                    // 5. تحديث التقرير بعد الدفع
                    LoadFinesReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء الدفع: {ex.Message}");
                }
            }
        }

        private void lblTotalFines_Click(object sender, EventArgs e)
        {

        }
    } 
}
