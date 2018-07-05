using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema.Entities
{
    /// <summary>
    /// HomeCinema Movie Genre
    /// </summary>
    public class Genre : IEntityBase
    {
        public Genre()
        {
            Movies = new List<Movie>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
    public class BookCategory : IEntityBase
    {
        public BookCategory()
        {
            Books = new List<Book>();
        }
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }

    }
}
