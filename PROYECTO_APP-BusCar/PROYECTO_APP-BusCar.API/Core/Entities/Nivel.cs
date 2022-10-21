using System;
using System.Collections.Generic;

using PROYECTO_APP_BusCar.API.Infrastructure.Data;

namespace PROYECTO_APP_BusCar.API.Core.Entities
{
    public partial class Nivel
    {
        public int IdNivel { get; set; }
        public string? Nombre { get; set; }
    }
}
