using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public interface IMemberService
    {
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberId);
        List<Member> GetAllMembers();
        // دالة جديدة للبحث عن عضو (مطلوبة للإعارة)
        Member GetMemberByContact(string contactNumber);
    }
}
