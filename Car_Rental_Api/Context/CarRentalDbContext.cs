using Car_Rental_Api.Models.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Car_Rental_Api.Context
{
    public class CarRentalDbContext : DbContext
    {
        public CarRentalDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
    }
}
