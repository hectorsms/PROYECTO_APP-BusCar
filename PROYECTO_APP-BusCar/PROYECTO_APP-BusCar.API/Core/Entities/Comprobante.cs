using System;
using System.Collections.Generic;
using PROYECTO_APP_BusCar.API.Infrastructure.Data;

namespace PROYECTO_APP_BusCar.API.Core.Entities
{
    public partial class Comprobante
    {
        public int IdComprobante { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }
    }
}
