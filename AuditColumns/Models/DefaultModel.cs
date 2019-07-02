using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditColumns.Models
{
    public class DefaultModel : IAuditable
    {
        public int ID { get; set; }
        public DateTime FECHA_CREACION { get; set; }
        public string USUARIO_CREACION { get; set; }
        public DateTime? FECHA_MODIFICACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
    }
}