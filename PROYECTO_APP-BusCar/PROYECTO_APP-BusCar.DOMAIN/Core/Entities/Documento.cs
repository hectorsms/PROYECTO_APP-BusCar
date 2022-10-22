using System;
using System.Collections.Generic;

namespace PROYECTO_APP_BusCar.DOMAIN.Core.Entities
{
    public partial class Documento
    {
        public int IdDocumento { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }
    }
}
