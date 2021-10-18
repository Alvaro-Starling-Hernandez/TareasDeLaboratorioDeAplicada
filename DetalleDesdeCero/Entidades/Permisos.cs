using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetalleDesdeCero.Entidades
{
    public class Permisos
    {
        [Key]
        public int PermisoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int vecesAsignado { get; set; }

        [ForeignKey("PermisoId")]
        public virtual List<RolesDetalle> RolesDetalle { get; set; } = new List<RolesDetalle>();
    }
}
