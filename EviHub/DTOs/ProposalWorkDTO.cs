﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EviHub.DTOs
{
    public class ProposalWorkDTO
    {

        [Key]
        public int ProposalWorkId { get; set; }
        public int ProposalId { get; set; }//FK
        public int EmpId { get; set; }//FK
        public bool? IsActive { get; set; }
       
       
    }
}

