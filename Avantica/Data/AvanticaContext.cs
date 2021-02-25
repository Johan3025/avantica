// ----------------------------------------------------------------------------
// <copyright file="AvanticaContext.cs" company="Encora S.A">
//     COPYRIGHT(C) 2020, Encora S.A
// </copyright>
// <author>Johan Ospina Nuñez</author>
// <email>jospina@Encora.com.</email>
// <summary>Context</summary>
// ----------------------------------------------------------------------------

using Avantica.Models;
using Microsoft.EntityFrameworkCore;

namespace Avantica.Data
{
    public class AvanticaContext : DbContext
    {
        public AvanticaContext(DbContextOptions<AvanticaContext> options)
            : base(options)
        {
        }

        public DbSet<Properties> Properties { get; set; }
    }
}
