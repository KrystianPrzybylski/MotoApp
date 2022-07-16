﻿namespace MotoApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using Entities;
    public class MotoAppDbContext:DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();

        public DbSet<BusinessPartner> BusinesPartners=>Set<BusinessPartner>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}
