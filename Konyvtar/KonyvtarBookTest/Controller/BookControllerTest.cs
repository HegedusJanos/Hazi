using FakeItEasy;
using Konyvtar_Api;
using Konyvtar_Api.Context;
using Microsoft.EntityFrameworkCore;
using Pass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarBookTest.Controller
{
    public class BookControllerTest
    {
        private KonyvtarApi2023Context _context;
        private async Task GetDBcontext()
        {
            var options = new DbContextOptionsBuilder<KonyvtarApi2023Context>()
                .UseSqlite()
                .UseLazyLoadingProxies(true)
                .Options;
            var DatabaseContext = new KonyvtarApi2023Context(options);
            _context = DatabaseContext;
        }
        [Fact]
        public void Book_Add_Book()
        {
            GetDBcontext();
            Book book = new Book();
            book.Id = 1;
            book.Title = "Asd";
            book.Author = "Asd";
            book.Creators = "Asd";
            book.CreatedDate = DateTime.Now;
            _context.book.Add(book);
            var asd = _context.book.Where(o => o.Title.Equals(book.Title));

            Assert.NotNull(asd);

            _context.book.Remove(book);
            var bsd = _context.book.Where(o => o.Title.Equals(book.Title));
            Assert.Null(bsd);
        }
    }
}
