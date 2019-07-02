using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuditColumns.Models
{
    public class JpContext : DbContext
    {
        public DbSet<Articulo> Articulos {get;set;}
        public JpContext() : base("DefaultConnection") { }
    }
}