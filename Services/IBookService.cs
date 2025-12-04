using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;


namespace LibraryManagementSystem.Services
{
    public interface IBookService
    {
        // Lec 06: تحديد وظائف CRUD
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int bookId);
        List<Book> GetAllBooks();
    }
}
