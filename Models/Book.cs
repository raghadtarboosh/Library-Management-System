using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    // Book.cs - يمثل جدول الكتب
    public class Book
    {
        // Property: المفتاح الأساسي (Primary Key)
        public int BookId { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int YearPublished { get; set; }

        // لتحديد حالة الكتاب (متاح للإعارة أم لا)
        public bool IsAvailable { get; set; }

        // Lec 08: لتحديد العلاقات (علاقة واحد إلى متعدد مع Borrowing)
        public virtual ICollection<Borrowing> Borrowings { get; set; }
    }
}
