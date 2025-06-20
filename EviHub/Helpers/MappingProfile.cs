﻿using AutoMapper;
using EviHub.Models.Entities;

using EviHub.DTOs;
using EviHub.EviHub.Core.Entities.MasterData;




namespace Evihub.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Proposal, ProposalDTO>().ReverseMap();
            CreateMap<ProposalWork, ProposalWorkDTO>().ReverseMap();
            CreateMap<Certification, CertificationDTO>().ReverseMap();
            CreateMap<CertificationCategory, CertificationCategoryDTO>().ReverseMap();
            CreateMap<CreateCertificationCategoryDTO, CertificationCategory>().ReverseMap();
            CreateMap<CertificationCategoryDTO, CertificationCategory>().ReverseMap();
            CreateMap<Certificationprogress, CertificationprogressDTO>().ReverseMap();
            CreateMap<CreateCertificationprogressDTO, Certificationprogress>().ReverseMap();
            CreateMap<UpdateCertificationprogressDTO, Certificationprogress>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            
     
           
            CreateMap<Certification, CertificationDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Designation, DesignationDTO>().ReverseMap();
            CreateMap<Gender, GenderDTO>().ReverseMap();
            CreateMap<Manager, ManagerDTO>().ReverseMap();
            CreateMap<Project, ProjectDTO>().ReverseMap();
            CreateMap<Skills, SkillDTO>().ReverseMap();


        }
    }
}
