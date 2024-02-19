using Car_Rental_Api.Models.Entitys;
using Car_Rental_Api.Models.Entitys.Entity_Config;
using Microsoft.EntityFrameworkCore;

namespace Car_Rental_Api.Context
{
    public class CarRentalDbContext : DbContext
    {
        public CarRentalDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CarEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new CustomerEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new EmployeeEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new InvoiceEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new RentEntityTypeConfig());
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
    }
}
