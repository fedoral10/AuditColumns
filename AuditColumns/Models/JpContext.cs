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

        public override int SaveChanges()
        {
            var changeSet = ChangeTracker.Entries<IAuditable>();

            if (changeSet != null)
            {
                foreach (var auditableEntry in changeSet)
                {
                    if (auditableEntry.State == EntityState.Added || auditableEntry.State == EntityState.Modified)
                    {
                        switch (auditableEntry.State)
                        {
                            case EntityState.Modified:
                                auditableEntry.Entity.FECHA_MODIFICACION = DateTime.Now;
                                auditableEntry.Entity.USUARIO_MODIFICACION = HttpContext.Current.User.Identity.Name;
                                break;
                            case EntityState.Added:
                                auditableEntry.Entity.FECHA_CREACION = DateTime.Now;
                                auditableEntry.Entity.USUARIO_CREACION = string.IsNullOrEmpty(HttpContext.Current.User.Identity.Name) ? "DevelGuest" : HttpContext.Current.User.Identity.Name;
                                break;
                        }
                    }
                }
            }
            return base.SaveChanges();
        }
    }
}