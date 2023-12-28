using Cohorts_Hw4.Entities.DbSets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Hw4.DataAccess.Context
{
    public class BookStoreDbContext:DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options):base(options)
        {
            
        }
        public DbSet<Book>   Books { get; set; }
    }
}
