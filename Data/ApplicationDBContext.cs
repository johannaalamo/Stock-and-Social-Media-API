﻿
using Microsoft.EntityFrameworkCore;
using ApiFinShark.Models;

namespace ApiFinShark.Data
{
    public class ApplicationDBContext : DbContext
    { 
        public ApplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        { 

        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
