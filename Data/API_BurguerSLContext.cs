using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_BurguerSL.Data.Models;

namespace API_BurguerSL.Data
{
    public class API_BurguerSLContext : DbContext
    {
        public API_BurguerSLContext (DbContextOptions<API_BurguerSLContext> options)
            : base(options)
        {
        }

        public DbSet<API_BurguerSL.Data.Models.Burger> Burger { get; set; } = default!;
    }
}
