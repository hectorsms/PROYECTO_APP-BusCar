using System;
using System.Collections.Generic;
using PROYECTO_APP_BusCar.API.Infrastructure.Data;

namespace PROYECTO_APP_BusCar.API.Core.Entities
    public partial class DetalleReserva
    {
        public int IdDetalleReserva { get; set; }
        public int? IdReserva { get; set; }
        public int? IdAsientoProg { get; set; }
        public string? NroDocumento { get; set; }
        public string? Nombres { get; set; }
        public string? Estado { get; set; }

        public virtual AsientoProgramacion? IdAsientoProgNavigation { get; set; }
        public virtual Reserva? IdReservaNavigation { get; set; }
    }
}
