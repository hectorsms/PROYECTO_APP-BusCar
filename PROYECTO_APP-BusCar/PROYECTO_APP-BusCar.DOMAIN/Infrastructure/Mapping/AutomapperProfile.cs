using AutoMapper;
using PROYECTO_APP_BusCar.DOMAIN.Core.DTOs;
using PROYECTO_APP_BusCar.DOMAIN.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_APP_BusCar.DOMAIN.Infrastructure.Mapping
{
    public  class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteDTO, Cliente>();
            CreateMap<ClienteCreateDTO, Cliente>();
            CreateMap<Cliente,ClienteCreateDTO>();

            CreateMap<Comprobante, ComprobanteDTO>();
            CreateMap<ComprobanteDTO, Comprobante>();
            CreateMap<ComprobanteCreateDTO, Comprobante>();
            CreateMap<Comprobante, ComprobanteCreateDTO>();

            CreateMap<Destino, DestinoDTO>();
            CreateMap<DestinoDTO, Destino>();
            CreateMap<DestinoCreateDTO, Destino>();
            CreateMap<Destino, DestinoCreateDTO>();

            CreateMap<DetalleReserva, DetalleReservaDTO>();
            CreateMap<DetalleReservaDTO, DetalleReserva>();
            CreateMap<DetalleReservaCreateDTO, DetalleReserva>();
            CreateMap<DetalleReserva, DetalleReservaCreateDTO>();


        }

    }
}
