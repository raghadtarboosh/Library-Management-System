using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public interface IFineService
    {
        // 📌 يجب أن تكون الدوال موقّعة في الواجهة
        decimal CalculateFineAmount(DateTime dueDate, DateTime returnDate);
        Fine AddFineRecord(int borrowingId, decimal amount);
        // (لتقرير الغرامات)
        List<Fine> GetUnpaidFines();
        void PayFine(int fineId);
    }
}
