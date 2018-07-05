using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema.Entities
{
   public  class Bulk : IEntityBase
    {
        //public Bulk()
        //{
        //   // Rentals = new List<Rental>();
        //}
        public int ID { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public Guid UniqueKey { get; set; }
        public bool IsAvailable { get; set; }
      //  public virtual ICollection<Rental> Rentals { get; set; }
    }
}
