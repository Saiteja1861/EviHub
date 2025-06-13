﻿using System.ComponentModel.DataAnnotations;

namespace EviHub.DTOs
{
    //public class EmployeeDTO
    //{


    //    public int EmpId { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string Email { get; set; }


    //}
    public class EmployeeDTO
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string Interests { get; set; }
        public int DesignationId { get; set; }
        public int? ManagerId { get; set; }
        public int? ProjectId { get; set; }
        public int GenderId { get; set; }
        public string EmergencyContact { get; set; }
        public bool? IsAdmin { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        //public class UpdateEmployeeDTO : CreateEmployeeDTO
        //{
        //    public int EmployeeId { get; set; }
        //}
    }
}