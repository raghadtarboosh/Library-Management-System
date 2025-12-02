using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
     public class Fine
    {
        public int FineId { get; set; }
        public decimal Amount { get; set; } 
        // Lec 01: استخدام decimal للتعامل الدقيق مع النقود
         public bool IsPaid { get; set; } public DateTime FineDate { get; set; }
        // المفتاح الأجنبي
         public int BorrowingId { get; set; } public virtual Borrowing Borrowing { get; set; } 
    }
}
