using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
namespace LibraryManagementSystem.Services
{
    public class BorrowingService : IBorrowingService
    {
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
            // ترك الدالة فارغة حالياً لإكمالها لاحقاً
            throw new NotImplementedException();
        }

        // **هنا سيتم إضافة منطق دالة GetActiveBorrowings في الخطوات التالية**
        public List<Borrowing> GetActiveBorrowings()
        {
            // ترك الدالة فارغة حالياً لإكمالها لاحقاً
            throw new NotImplementedException();
        }
    }
}
