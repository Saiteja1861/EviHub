﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EviHub.Models.Entities
{
    public class Certificationprogress
    {
        [Key]
        public int CertificationProgressId { get; set; }
        public int CertificationId { get; set; }//FK
        public int EmpId { get; set; }//FK
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }


        //Navigation Property
        [ForeignKey("EmpId")]
        public Employee Employee { get; set; }
        [ForeignKey("CertificationId")]
        public Certification Certification { get; set; }
    }
}
