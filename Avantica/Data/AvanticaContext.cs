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

        public DbSet<Avantica.Models.Properties> Properties { get; set; }

        public DbSet<Avantica.Models.User> User { get; set; }
    }
}
