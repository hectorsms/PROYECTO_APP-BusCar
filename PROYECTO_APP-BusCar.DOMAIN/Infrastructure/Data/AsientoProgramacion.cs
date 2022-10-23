using System;
using System.Collections.Generic;

namespace PROYECTO_APP_BusCar.DOMAIN.Infrastructure.Data
{
    public partial class AsientoProgramacion
    {
        public AsientoProgramacion()
        {
            DetalleReserva = new HashSet<DetalleReserva>();
        }

        public int IdAsientoProg { get; set; }
        public int? IdProgramacion { get; set; }
        public int? IdAsiento { get; set; }
        public string? Estado { get; set; }

        public virtual Programacion? IdProgramacionNavigation { get; set; }
        public virtual ICollection<DetalleReserva> DetalleReserva { get; set; }
    }
}
