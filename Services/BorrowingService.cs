using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity; // 📌 يجب إضافتها لدعم دالة Include()
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LibraryManagementSystem.Services

{
    public class BorrowingService : IBorrowingService
    {
        private IFineService _fineService = new FineService(); // في BorrowingService
        private IBookService _bookService = new BookService();

        // Lec 08 & LINQ: تنفيذ عملية الإعارة
        public bool BorrowBook(int memberId, int bookId, int borrowDays = 7) // الإعارة لمدة 7 أيام افتراضياً
        {
            using (var context = new LibraryContext())
            {
                var book = context.Books.Find(bookId);
                var member = context.Members.Find(memberId);

                // تحقق مبدئي: هل الكتاب والعضو موجودان وهل الكتاب متاح؟
                if (book == null || member == null || !book.IsAvailable)
                    return false; // فشل الإعارة

                // 1. إنشاء سجل الإعارة (Borrowing Object)
                var newBorrowing = new Borrowing
                {
                    MemberId = memberId,
                    BookId = bookId,
                    BorrowDate = DateTime.Now,
                    // Lec 01: استخدام دالة AddDays لحساب تاريخ الإرجاع المستحق
                    DueDate = DateTime.Now.AddDays(borrowDays),
                    ReturnDate = null // لم يتم الإرجاع بعد
                };

                // 2. تحديث حالة الكتاب (جعله غير متاح)
                book.IsAvailable = false;

                // 3. إضافة سجل الإعارة إلى قاعدة البيانات وحفظ التغييرات
                context.Borrowings.Add(newBorrowing);
                context.SaveChanges();
                return true;
            }
        }

        // **هنا سيتم إضافة منطق دالة ReturnBook في الخطوات التالية**
        public bool ReturnBook(int borrowingId)
        {
            using (var context = new LibraryContext())
            {
                // 1. LINQ: جلب سجل الإعارة وعلاقاته (Include)
                var borrowing = context.Borrowings
                                       .Include(b => b.Book) // جلب بيانات الكتاب المتصلة
                                       .SingleOrDefault(b => b.BorrowingId == borrowingId && b.ReturnDate == null);

                if (borrowing == null) return false;

                // 2. تحديث تاريخ الإرجاع
                borrowing.ReturnDate = DateTime.Now;

                // 3. تحديث حالة الكتاب
                borrowing.Book.IsAvailable = true;

                // 4. حساب الغرامة
                decimal fineAmount = _fineService.CalculateFineAmount(borrowing.DueDate, (DateTime)borrowing.ReturnDate);

                if (fineAmount > 0)
                {
                    // 5. تسجيل الغرامة في جدول Fines
                    _fineService.AddFineRecord(borrowingId, fineAmount);
                    MessageBox.Show($"تنبيه: الكتاب متأخر! تم تسجيل غرامة بقيمة {fineAmount:C} ريال.");
                }

                context.SaveChanges();
                return true;
            }

            throw new NotImplementedException();
        }

        // **هنا سيتم إضافة منطق دالة GetActiveBorrowings في الخطوات التالية**
        public List<Borrowing> GetActiveBorrowings()
        {
            // 📌 يجب أن تبدأ بجملة using هنا لتعريف context وضمان إغلاق الاتصال
            using (var context = new LibraryContext())
            {
                // ✅ الآن context متاح، ويمكنك استخدامه هنا:
                return context.Borrowings
                              // LINQ: تصفية السجلات التي لم يتم إرجاعها (ReturnDate == null)
                              .Where(b => b.ReturnDate == null)
                              // تضمين بيانات العضو والكتاب للعرض
                              .Include(b => b.Member)
                              .Include(b => b.Book)
                              .ToList();
            }
        }
    }
}
