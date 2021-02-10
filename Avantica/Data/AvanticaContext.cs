using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Avantica.Models;

namespace Avantica.Data
{
    public class AvanticaContext : DbContext
    {
        public AvanticaContext (DbContextOptions<AvanticaContext> options)
            : base(options)
        {
        }

        public DbSet<Properties> Properties { get; set; }
    }
}
