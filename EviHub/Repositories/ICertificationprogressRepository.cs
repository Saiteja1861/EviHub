﻿using EviHub.Models.Entities;


namespace Evihub.Repositories
{
    public interface ICertificationprogressRepository
    {
        Task<IEnumerable<Certificationprogress>> GetAllAsync();
        Task<Certificationprogress> GetByIdAsync(int id);
        Task<Certificationprogress> AddAsync(Certificationprogress progress);
        Task UpdateAsync(Certificationprogress progress);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<Certificationprogress>> GetByEmployeeIdAsync(int id);
        Task<List<Certificationprogress>> GetByCertificationIdAsync(int id);
    }
}
