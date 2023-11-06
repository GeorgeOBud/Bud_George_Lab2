using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bud_George_Lab2.Models;

namespace Bud_George_Lab2.Data
{
    public class Bud_George_Lab2Context : DbContext
    {
        public Bud_George_Lab2Context (DbContextOptions<Bud_George_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bud_George_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Bud_George_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Bud_George_Lab2.Models.Author>? Author { get; set; }
    }
}
