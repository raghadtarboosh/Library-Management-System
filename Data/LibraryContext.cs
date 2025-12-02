using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Data
{
    public class LibraryContext : DbContext
    {
        // Lec 08: DbSet لكل جدول في قاعدة البيانات
        public DbSet<User> Users { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<Fine> Fines { get; set; }

        public LibraryContext() : base("LibraryDBConnection")
        {
            // تهيئة بسيطة للبيانات إذا لم تكن قاعدة البيانات موجودة
            Database.SetInitializer<LibraryContext>(new DropCreateDatabaseIfModelChanges<LibraryContext>());
        }

        // هنا يمكن تعريف العلاقات بشكل صريح، كما ذكرنا في شرح المحاضرة 8
    }
}
