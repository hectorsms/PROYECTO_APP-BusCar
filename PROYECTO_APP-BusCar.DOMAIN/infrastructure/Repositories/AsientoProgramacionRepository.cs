using Microsoft.EntityFrameworkCore;
using PROYECTO_APP_BusCar.DOMAIN.Core.Entities;
using PROYECTO_APP_BusCar.DOMAIN.Core.Interfaces;
using PROYECTO_APP_BusCar.DOMAIN.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_APP_BusCar.DOMAIN.infrastructure.Repositories
{
    public class AsientoProgramacionRepository : IAsientoProgramacionRepository
    {
        private readonly DB_BUSContext _context;

        public AsientoProgramacionRepository(DB_BUSContext context)
        {
            _context = context;

        }

        public async Task<IEnumerable<AsientoProgramacion>> GetAsientoProgramacion()
        {
            var asientosprogramacion = await _context.AsientoProgramacion.ToListAsync();
            return asientosprogramacion;
        }

        public async Task<AsientoProgramacion> GetAsientoProgramacion(int id)
        {
            return await _context.AsientoProgramacion.Where(x => x.IdAsientoProg == id).FirstOrDefaultAsync();
        }

        public async Task<bool> Insert(Asiento asiento)
        {
            await _context.Asiento.AddAsync(asiento);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Update(Asiento asiento)
        {
            _context.Asiento.Update(asiento);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Delete(int id)
        {
            var asiento = await _context.Asiento.FindAsync(id);
            if (asiento == null)
                return false;
            _context.Asiento.Remove(asiento);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }
    }
}
