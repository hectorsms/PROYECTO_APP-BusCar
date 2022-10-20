using System;
using System.Collections.Generic;

namespace PROYECTO_APP_BusCar.DOMAIN.Core.Entities
{
    public partial class Destino
    {
        public int IdDestino { get; set; }
        public string? Ciudad { get; set; }
        public string? Estado { get; set; }
    }
}
