using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public interface IBorrowingService
    {
        // Lec 06: دالة لإعارة كتاب
        bool BorrowBook(int memberId, int bookId, int borrowDays);

        // دالة لإرجاع كتاب
        bool ReturnBook(int borrowingId);

        // دالة لجلب جميع الإعارات النشطة (غير المرجعة)
        List<Borrowing> GetActiveBorrowings();
    }


}
