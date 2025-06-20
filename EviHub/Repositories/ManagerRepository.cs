﻿using EviHub.Data;
using Microsoft.EntityFrameworkCore;
using EviHub.EviHub.Core.Entities.MasterData;
using EviHub.Repositories.Interfaces;
using Evihub.Data;

namespace EviHub.Repositories
{
    public class ManagerRepository:IManagerRepository
    {
        private readonly EviHubDbContext _context;

        public ManagerRepository(EviHubDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Manager>> GetAllAsync()
        {
            return await _context.Managers.ToListAsync();
        }

        public async Task<Manager> AddAsync(Manager manager)
        {
            _context.Managers.Add(manager);
            await _context.SaveChangesAsync();
            return manager;
        }

        public async Task<Manager> UpdateAsync(int id, Manager updatedManager)
        {
            var manager = await _context.Managers.FindAsync(id);
            if (manager == null) return null;

            manager.EmpId = updatedManager.EmpId;
            manager.FirstName = updatedManager.FirstName;
            manager.LastName = updatedManager.LastName;
            manager.Mobile = updatedManager.Mobile;
            manager.Email = updatedManager.Email;

            await _context.SaveChangesAsync();
            return manager;
        }
        public  async Task<Manager> GetByIdAsync(int id)
        {
            return await _context.Managers
                .FirstOrDefaultAsync (m => m.ManagerId == id);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var manager = await _context.Managers.FindAsync(id);
            if (manager == null) return false;

            _context.Managers.Remove(manager);
            await _context.SaveChangesAsync();
            return true;
        }
    }


}




