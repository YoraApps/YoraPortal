﻿using HomeCinema.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema.Data.Configurations
{
   public  class BookConfiguration : EntityBaseConfiguration<Book>
    {
     public BookConfiguration()
        {
            Property(m => m.Title).IsRequired().HasMaxLength(100);
            Property(m => m.GenreId).IsRequired();
            Property(m => m.Director).IsRequired().HasMaxLength(100);
            Property(m => m.Writer).IsRequired().HasMaxLength(50);
            Property(m => m.Producer).IsRequired().HasMaxLength(50);
            Property(m => m.Writer).HasMaxLength(50);
            Property(m => m.Producer).HasMaxLength(50);
            Property(m => m.Rating).IsRequired();
            Property(m => m.Description).IsRequired().HasMaxLength(2000);
            Property(m => m.TrailerURI).HasMaxLength(200);
            HasMany(m => m.Bulk).WithRequired().HasForeignKey(s => s.BookId);
        }
    }
}