using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudWithAngular.Models;

namespace CrudWithAngular.Data
{
    public class CrudWithAngularContext : DbContext
    {
        public CrudWithAngularContext (DbContextOptions<CrudWithAngularContext> options)
            : base(options)
        {
        }

        public DbSet<CrudWithAngular.Models.Product> Product { get; set; } = default!;
    }
}
