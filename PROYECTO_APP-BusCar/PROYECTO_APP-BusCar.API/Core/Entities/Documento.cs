using System;
using System.Collections.Generic;
using PROYECTO_APP_BusCar.API.Infrastructure.Data;

namespace PROYECTO_APP_BusCar.API.Core.Entities
{
    public partial class Documento
    {
        public Documento()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int IdDocumento { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
