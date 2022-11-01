using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marian_Cristina_lab02.Models;

namespace Marian_Cristina_lab02.Data
{
    public class Marian_Cristina_lab02Context : DbContext
    {
        public Marian_Cristina_lab02Context (DbContextOptions<Marian_Cristina_lab02Context> options)
            : base(options)
        {
        }

        public DbSet<Marian_Cristina_lab02.Models.Book> Book { get; set; } = default!;

        public DbSet<Marian_Cristina_lab02.Models.Publisher> Publisher { get; set; }

        public DbSet<Marian_Cristina_lab02.Models.Author> Author { get; set; }

        public DbSet<Marian_Cristina_lab02.Models.Category> Category { get; set; }
    }
}
