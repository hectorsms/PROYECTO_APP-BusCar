using System;
using System.Collections.Generic;

using PROYECTO_APP_BusCar.API.Infrastructure.Data;

namespace PROYECTO_APP_BusCar.API.Core.Entities
{
    public partial class Cargo
    {
        public Cargo()
        {
            Personal = new HashSet<Personal>();
        }

        public int IdCargo { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }

        public virtual ICollection<Personal> Personal { get; set; }
    }
}
