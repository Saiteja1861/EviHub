﻿using EviHub.EviHub.Core.Entities.MasterData;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EviHub.Models.Entities
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string Interests { get; set; }
        public int DesignationId { get; set; }//FK
        public int? ManagerId { get; set; }//FK
        public int? ProjectId { get; set; }//FK
        public int   GenderId { get; set; }//FK
        //public int  SkillId { get; set; }//FK
        //public int RoleId { get; set; }//FK
        //public int UserId { get; set; }//FK
        ////public int ProposalId { get; set; } //FK

       // public int ProposalWorkId { get; set; }//FK
        //public int CertificationProgressId { get; set; }//FK
        public string EmergencyContact { get; set; }
        public bool? IsAdmin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        
        public virtual Manager Manager { get; set; }//Manager of Employee
        public virtual Designation Designation { get; set; }//designation of Employee
        public virtual Project Project { get; set; }//Project of Employee
        public virtual Gender Gender { get; set; }//Gender of Employee
       
       // public ICollection<Employee> EmployeesUnderManager { get; set; }//one to many(Employees managed by this employee(Manager)
        //public ICollection<Skills>Skills { get; set; }//Employee can have multiple skills
        public ICollection<EmployeeSkills> EmployeeSkills { get; set; }


        public ICollection<EmployeeProject> EmployeeProjects { get; set; }//Multiple Projects
        public ICollection<Proposal> Proposals { get; set; }//Multiple Proposals
        public ICollection<ProposalWork> ProposalWorks { get; set; }
        public ICollection<Certificationprogress> Certificationprogress { get; set; }








    }
}
