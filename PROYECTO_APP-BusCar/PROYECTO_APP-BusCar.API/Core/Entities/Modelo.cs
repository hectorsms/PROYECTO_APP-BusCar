using System;
using System.Collections.Generic;

using PROYECTO_APP_BusCar.API.Infrastructure.Data;

namespace PROYECTO_APP_BusCar.API.Core.Entities
{
    public partial class Modelo
    {
        public Modelo()
        {
            Bus = new HashSet<Bus>();
        }

        public int IdModelo { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }

        public virtual ICollection<Bus> Bus { get; set; }
    }
}
