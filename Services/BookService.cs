using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using System.Data.Entity; // مهمة لاستخدام .Include() إذا احتجنا إليها لاحقاً

namespace LibraryManagementSystem.Services
{
    public class BookService : IBookService
    {
        // Lec 08 & LINQ: تنفيذ عمليات CRUD

        // 1. عملية الإضافة (Create - AddBook)
        public void AddBook(Book book)
        {
            using (var context = new LibraryContext())
            {
                context.Books.Add(book);
                context.SaveChanges(); // حفظ التغييرات في DB
            }
        }

        // 2. عملية القراءة (Read - GetAllBooks)
        public List<Book> GetAllBooks()
        {
            using (var context = new LibraryContext())
            {
                // LINQ: لجلب جميع الكتب من جدول Books
                return context.Books.ToList();
            }
        }

        // 3. عملية التعديل (Update - UpdateBook)
        public void UpdateBook(Book book)
        {
            using (var context = new LibraryContext())
            {
                // أ. البحث عن الكتاب الموجود باستخدام ID (Find هي طريقة سريعة في EF)
                var existingBook = context.Books.Find(book.BookId);

                if (existingBook != null)
                {
                    // ب. تحديث خصائص الكائن الموجود بالبيانات الجديدة (Lec 05: Properties)
                    existingBook.Title = book.Title;
                    existingBook.Author = book.Author;
                    existingBook.ISBN = book.ISBN;
                    existingBook.YearPublished = book.YearPublished;
                    // خاصية IsAvailable نتركها كما هي (يتم تحديثها فقط عبر عملية الإعارة/الإرجاع)

                    // ج. حفظ التغييرات في قاعدة البيانات
                    context.SaveChanges();
                }
            }
        }

        // 4. عملية الحذف (Delete - DeleteBook)
        public void DeleteBook(int bookId)
        {
            using (var context = new LibraryContext())
            {
                // أ. البحث عن الكتاب المراد حذفه
                var bookToDelete = context.Books.Find(bookId);

                if (bookToDelete != null)
                {
                    // ب. إزالة الكائن من DbSet
                    context.Books.Remove(bookToDelete);

                    // ج. حفظ التغييرات
                    context.SaveChanges();
                }
            }
        }

        // 5. دالة إضافية: جلب الكتب المتاحة فقط (مطلوبة لعملية الإعارة)
        public List<Book> GetAvailableBooks()
        {
            using (var context = new LibraryContext())
            {
                // LINQ: تصفية الكتب التي خاصية IsAvailable فيها true
                return context.Books.Where(b => b.IsAvailable == true).ToList();
            }
        }


    }
}
