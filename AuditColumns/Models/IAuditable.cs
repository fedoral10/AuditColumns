using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditColumns.Models
{
    public interface IAuditable
    {
        DateTime FECHA_CREACION { get; set; }
        string USUARIO_CREACION { get; set; }

        DateTime? FECHA_MODIFICACION { get; set; }
        string USUARIO_MODIFICACION { get; set; }
    }
}