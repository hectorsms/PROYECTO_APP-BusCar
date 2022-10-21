using System;
using System.Collections.Generic;
using PROYECTO_APP_BusCar.API.Infrastructure.Data;

namespace PROYECTO_APP_BusCar.API.Core.Entities
{
    public partial class Precio
    {
        public int IdPrecio { get; set; }
        public int? IdOrigen { get; set; }
        public int? IdDestino { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Precio1 { get; set; }
        public string? Estado { get; set; }

        public virtual Destino? IdDestinoNavigation { get; set; }
        public virtual Origen? IdOrigenNavigation { get; set; }
    }
}
