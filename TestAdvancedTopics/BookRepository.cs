using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdvancedTopics
{
    public class BookRepository
    {
        public static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Book Title 1", Price = 120 },
                new Book() {Title = "Book Title 2", Price = 170 },
                new Book() {Title = "Book Title 3", Price = 330 }
            };
        }
    }
}
