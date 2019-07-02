using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AuditColumns.Models
{
    [Table("ARTICULO")]
    public class Articulo:DefaultModel
    {
        public string NOMBRE { get; set; }
        public double COSTO { get; set; }
    }
}