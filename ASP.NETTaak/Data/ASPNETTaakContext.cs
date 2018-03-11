using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETTaak.Models
{
    public class ASPNETTaakContext : DbContext
    {
        public ASPNETTaakContext (DbContextOptions<ASPNETTaakContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NETTaak.Models.Movie> Movie { get; set; }
    }
}
