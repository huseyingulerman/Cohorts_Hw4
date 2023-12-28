using Cohorts_Hw4.DataAccess.Context;
using Cohorts_Hw4.Entities.DbSets;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Hw4.DataAccess.Seed
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(new Book()
                {
                    Id = 1,
                    Title = "Lean Startup",
                    GenreId = 1,
                    PageCount = 250,
                    PublishDate = new DateTime(2001, 10, 12)

                },
                new Book
                {
                    Id = 2,
                    Title = "Herland",
                    GenreId = 1,
                    PageCount = 250,
                    PublishDate = new DateTime(2011, 05, 12)
                },
                 new Book
                 {
                     Id = 3,
                     Title = "Dune",
                     GenreId = 2,
                     PageCount = 540,
                     PublishDate = new DateTime(2001, 12, 12)
                 }
                );
                context.SaveChanges();
            }
        }
    }
}
