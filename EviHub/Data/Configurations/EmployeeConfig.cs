﻿using EviHub.EviHub.Core.Entities.MasterData;
using EviHub.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EviHub.Data.Configurations
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmpId);
            //builder.Property(e => e.EmpId).IsRequired().HasMaxLength(50);
            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Mobile).IsRequired().HasMaxLength(15);
            builder.Property(e => e.Interests).HasMaxLength(500);
            builder.Property(e => e.EmergencyContact).IsRequired().HasMaxLength(15);
            builder.Property(e => e.IsAdmin).HasDefaultValue(false);

            //builder.HasOne(e=>e.Designation)
            //    .WithMany(d=>d.Employee)
            //    .HasForeignKey(e => e.DesignationId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.HasOne(e => e.Manager)
            //    .WithMany(m => m.EmployeesUnderManager)
            //    .HasForeignKey(e => e.ManagerId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(e=>e.Gender)
            //    .WithMany(g=>g.Employees)
            //    .HasForeignKey(e => e.GenderId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(e=>e.Login )
            //    .WithOne(l => l.Employee)
            //    .HasForeignKey<Login>(l => l.UserId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.HasMany(u =>u.UserRoles)
            //    .WithOne(e =>e.Employee)
            //    .HasForeignKey(r => r.RoleId)
            //    .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.EmployeeProjects)
                .WithOne(g => g.Employee)
                .HasForeignKey(e => e.EmpId)
                .OnDelete(DeleteBehavior.Restrict);







        }

    }       
}
