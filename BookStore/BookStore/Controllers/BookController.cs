using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookModel _bookModel = null;
        public BookController()
        {
            _bookModel = new BookModel();
        }

        public List<BookModel> GetAllBooks()
        {
            return _bookModel.GetAllBooks();  
        }

        public BookModel GetBookById(int id)
        {
            return _bookModel.GetBookById(id);
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return _bookModel.SearchBook(title, author);
        }

    }
}