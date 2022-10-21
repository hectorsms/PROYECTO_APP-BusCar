using System;
using System.Collections.Generic;
using PROYECTO_APP_BusCar.API.Infrastructure.Data;

namespace PROYECTO_APP_BusCar.API.Core.Entities
{
    public partial class Usuario
    {
        public int IdUser { get; set; }
        public string? Usuario1 { get; set; }
        public string? Clave { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Estado { get; set; }
        public int? IdPersonal { get; set; }

        public virtual Personal? IdPersonalNavigation { get; set; }
    }
}
