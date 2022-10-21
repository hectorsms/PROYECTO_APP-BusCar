using System;
using System.Collections.Generic;

using PROYECTO_APP_BusCar.API.Infrastructure.Data;

namespace PROYECTO_APP_BusCar.API.Core.Entities
{
    public partial class Bus
    {
        public Bus()
        {
            Programacion = new HashSet<Programacion>();
        }

        public int IdBus { get; set; }
        public int? IdModelo { get; set; }
        public int? IdMarca { get; set; }
        public string? Descripcion { get; set; }
        public string? Placa { get; set; }
        public int? NroAsientos { get; set; }
        public string? Estado { get; set; }

        public virtual Marca? IdMarcaNavigation { get; set; }
        public virtual Modelo? IdModeloNavigation { get; set; }
        public virtual ICollection<Programacion> Programacion { get; set; }
    }
}
