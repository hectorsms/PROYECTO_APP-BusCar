﻿using System;
using Microsoft.EntityFrameworkCore;
using PROYECTO_APP_BusCar.API.Core.Entities;
using PROYECTO_APP_BusCar.API.Infrastructure.Data;

namespace PROYECTO_APP_BusCar.API.Infrastructure.Repositories
{
    public class BusRepository
    {
        private readonly DB_BUSContext _context;

        public BusRepository(DB_BUSContext context)
        {
            _context = context;

        }


        public async Task<IEnumerable<Bus>> GetBuses()
        {
            var buses = await _context.Bus.ToListAsync();
            return buses;
        }

        public async Task<Bus> GetBus(int id)
        {
            return await _context.Bus.Where(x => x.IdBus == id).FirstOrDefaultAsync();
        }

        public async Task<bool> Insert(Bus bus)
        {
            await _context.Bus.AddAsync(bus);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Update(Bus bus)
        {
            _context.Bus.Update(bus);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Delete(int id)
        {
            var bus = await _context.Bus.FindAsync(id);
            if (bus == null)
                return false;
            _context.Bus.Remove(bus);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }
    }
}
