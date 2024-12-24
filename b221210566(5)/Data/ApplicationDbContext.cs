﻿using b221210566_5_.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace b221210566_5_.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<EmployeeManager> EmployeeManager { get; set; }
        public DbSet<Appointments> appointments { get; set; }
        public DbSet<AppointmentEmployee> appointmentEmployees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().
                HasOne<Department>()
                .WithMany(d => d.Employees);

            builder.Entity<EmployeeManager>()
              .HasOne(em => em.Employees)  
              .WithOne(e => e.EmployeeManager)  
              .HasForeignKey<EmployeeManager>(em => em.EmployeeID);  // Foreign key in EmployeeManager for Employee

            builder.Entity<EmployeeManager>()
                .HasOne(em => em.Managers)  
                .WithMany(m => m.EmployeeManager)  
                .HasForeignKey(em => em.ManagerId);


            builder.Entity<Appointments>()
                    .HasOne<User>()
                    .WithMany(u => u.Appointments);

            // Define the relationship for AppointmentEmployee - Appointment (one-to-many)
            builder.Entity<AppointmentEmployee>()
                .HasOne(ae => ae.Appointment)               
                .WithMany(a => a.AppointmentEmployees)       
                .HasForeignKey(ae => ae.AppointmentId);      

            // Define the relationship for AppointmentEmployee - Employee (many-to-one)
            builder.Entity<AppointmentEmployee>()
                .HasOne(ae => ae.Employee)                  
                .WithMany(e => e.AppointmentEmployees)     
                .HasForeignKey(ae => ae.EmployeeId);         
             



            var adminId = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminId,Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "Employee", NormalizedName = "EMPLOYEE" },
                new IdentityRole { Name = "Manager", NormalizedName = "MANAGER" },
                new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" }
            );

            var adminUserId = Guid.NewGuid().ToString(); // Sabit ID
            var adminUser = new User
            {
                Id = adminUserId,
                UserName = "Sara Mohamed",
                FirstName = "Sara",
                LastName ="Mohamed",
                NormalizedUserName = "SaraMohamed",
                Email = "b221210566@ogr.sakarya.edu.tr",
                NormalizedEmail = "b221210566@ogr.sakarya.edu.tr",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "sau"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
            };

            builder.Entity<User>().HasData(adminUser);

            // Admin Kullanıcıya Rol Ekleme (UserRole tablosu seedleme)
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminId, // Admin rol ID'si
                    UserId = adminUserId// Admin kullanıcı ID'si
                });
        
            builder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Hair Cut"},
                new Department { Id = 2, Name = "Hair Care"},
                new Department { Id = 3, Name = "Hair Dye"},
                new Department { Id = 4, Name = "Manikur"},
                new Department { Id = 5, Name = "Padikur"}
            );
            base.OnModelCreating(builder);
        }
    }
}
