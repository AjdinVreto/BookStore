using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x => x.Author.Contains(author) || x.Title.Contains(title)).ToList();
        }

        private List<BookModel> DataSource()
        {
            List<BookModel> sveKnjige = new List<BookModel>();

            sveKnjige.Add(new BookModel { Id = 1, Title = "ASP.Net", Author = "John" });
            sveKnjige.Add(new BookModel { Id = 2, Title = "Java", Author = "Monika" });
            sveKnjige.Add(new BookModel { Id = 3, Title = "C#", Author = "Ajdin" });

            return sveKnjige;
        }

    }
}
