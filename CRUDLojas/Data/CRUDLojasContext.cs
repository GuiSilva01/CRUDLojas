using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUDLojas.Models
{
    public class CRUDLojasContext : DbContext
    {
        public CRUDLojasContext (DbContextOptions<CRUDLojasContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDLojas.Models.Loja> Loja { get; set; }
    }
}
