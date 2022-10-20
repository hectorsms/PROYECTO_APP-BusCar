﻿using PROYECTO_APP_BusCar.DOMAIN.Core.Entities;

namespace PROYECTO_APP_BusCar.DOMAIN.Core.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetClientes();
        Task<bool> Delete(int idCliente);
        Task<Cliente> GetCliente(int idCliente);
        Task<Cliente> GetClienteDoc(int idDocumento, string dni);
        Task<bool> Insert(Cliente cliente);
        Task<bool> Update(Cliente cliente);
    }
}