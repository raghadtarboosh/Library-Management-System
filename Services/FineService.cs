using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class FineService : IFineService
    {
        private const decimal DAILY_FINE_RATE = 0.50m; // قيمة الغرامة اليومية (مثال: 0.50 ريال/دولار)
        public decimal CalculateFineAmount(DateTime dueDate, DateTime returnDate)
        {
            // Lec 01: استخدام TimeSpan لحساب الفرق بين التواريخ
            TimeSpan delay = returnDate - dueDate;

            if (delay.Days > 0)
            {
                return delay.Days * DAILY_FINE_RATE; // حساب مبلغ الغرامة
            }
            return 0m; // لا توجد غرامة
        }

        public Fine AddFineRecord(int borrowingId, decimal amount)
        {
            using (var context = new LibraryContext())
            {
                var fine = new Fine
                {
                    BorrowingId = borrowingId,
                    Amount = amount,
                    FineDate = DateTime.Now,
                    IsPaid = false // افتراضياً غير مدفوعة
                };
                context.Fines.Add(fine);
                context.SaveChanges();
                return fine;
            }
        }
       
       
        // داخل FineService.cs
        public List<Fine> GetUnpaidFines()
        {
            using (var context = new LibraryContext())
            {
                // LINQ: جلب الغرامات التي لم يتم دفعها بعد
                return context.Fines.Where(f => f.IsPaid == false)
                                    .Include(f => f.Borrowing.Member) // جلب بيانات العضو المرتبطة
                                    .ToList();
            }
        
        }
        // داخل FineService.cs
        public void PayFine(int fineId)
        {
            using (var context = new LibraryContext())
            {
                var fine = context.Fines.Find(fineId);
                if (fine != null && !fine.IsPaid)
                {
                    fine.IsPaid = true; // تعيين حالة الدفع إلى true
                    context.SaveChanges();
                }
            }
        }
    }
}