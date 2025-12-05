using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public class MemberService : IMemberService
    {
        // تنفيذ عملية الإضافة (Add)
        public void AddMember(Member member)
        {
            using (var context = new LibraryContext())
            {
                context.Members.Add(member);
                context.SaveChanges();
            }
        }

        // تنفيذ عملية التعديل (Update)
        public void UpdateMember(Member member)
        {
            using (var context = new LibraryContext())
            {
                // Find هي الطريقة الأسرع في Entity Framework للبحث بالـ ID
                var existingMember = context.Members.Find(member.MemberId);
                if (existingMember != null)
                {
                    // تحديث الخصائص
                    existingMember.FullName = member.FullName;
                    existingMember.ContactNumber = member.ContactNumber;
                    existingMember.Email = member.Email;
                    context.SaveChanges(); // حفظ التعديل في قاعدة البيانات
                }
            }
        }

        // تنفيذ عملية الحذف (Delete)
        public void DeleteMember(int memberId)
        {
            using (var context = new LibraryContext())
            {
                var memberToDelete = context.Members.Find(memberId);
                if (memberToDelete != null)
                {
                    context.Members.Remove(memberToDelete);
                    context.SaveChanges(); // حفظ الحذف في قاعدة البيانات
                }
            }
        }

        // جلب جميع الأعضاء (Read All)
        public List<Member> GetAllMembers()
        {
            using (var context = new LibraryContext())
            {
                return context.Members.ToList();
            }
        }

        // تنفيذ دالة البحث لعملية الإعارة
        public Member GetMemberByContact(string contactNumber)
        {
            using (var context = new LibraryContext())
            {
                // LINQ: FirstOrDefault للبحث عن رقم الاتصال
                return context.Members.FirstOrDefault(m => m.ContactNumber == contactNumber);
            }
        }
    }
}
