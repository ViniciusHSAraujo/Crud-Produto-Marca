using Crud_Produto_Marca.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Produto_Marca.Database {
    public class ApplicationDbContext : DbContext {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Produto> Produtos { get; set; }

    }
}
