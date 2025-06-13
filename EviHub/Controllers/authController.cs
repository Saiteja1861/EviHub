using Evihub.Data;
using EviHub.DTOs;
using EviHub.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EviHub.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class authController : ControllerBase
    {
        private readonly EviHubDbContext _context;
        public authController(EviHubDbContext context)
        {
            _context = context;
        }
        [HttpPost("register")]
        public async Task<IActionResult> PostEmployee([FromBody] EmployeeDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var employee = new Employee
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                EmpId = dto.EmpId,
                Email = dto.Email,
                Mobile = dto.Mobile,
                DOB = dto.DOB,
                ManagerId = dto.ManagerId,
                DesignationId = dto.DesignationId,
                Username = dto.Username,
                Password = dto.Password,

            };
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
