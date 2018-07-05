using HomeCinema.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema.Data.Configurations
{
   public  class BulkConfiguration : EntityBaseConfiguration<Bulk>
    {
        public BulkConfiguration()
        {
            Property(s => s.BookId).IsRequired();
            Property(s => s.UniqueKey).IsRequired();
            Property(s => s.IsAvailable).IsRequired();
          
        }
    }
}
