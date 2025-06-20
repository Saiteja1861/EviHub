﻿using EviHub.EviHub.Core.Entities.MasterData;

using EviHub.Models.Entities;

namespace EviHub.Repositories.Interfaces
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetAllAsync();
        Task<Project> AddAsync(Project project);
        Task<Project> UpdateAsync(int id, Project project);
        Task<Project> GetByIdAsync(int id);
        Task<bool> DeleteAsync(int id);
        Task<EmployeeProject> AssignAsync(EmployeeProject Employeeproject);
    }
}

