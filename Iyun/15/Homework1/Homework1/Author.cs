using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Author
    {
        public List<Book> authorBooks = new List<Book>();
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int AuthorAge { get; set; }
    }
}
