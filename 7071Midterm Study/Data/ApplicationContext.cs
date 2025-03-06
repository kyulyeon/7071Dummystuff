using Microsoft.EntityFrameworkCore;
using System;
using _7071Midterm_Study.Model;

namespace _7071Midterm_Study.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<FullAddress> FullAddresses { get; set; }
        public DbSet<FullName> FullNames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().HasKey(p => p.ID);
            modelBuilder.Entity<Service>().HasKey(s => s.ID);
            modelBuilder.Entity<Client>().HasMany(c => c.Services).WithMany(s => s.Clients);
            modelBuilder.Entity<Employee>().HasMany(e => e.Services).WithMany(s => s.Employees);

            // Seed data for FullAddress and FullName already use static values.
            modelBuilder.Entity<FullAddress>().HasData(
                new FullAddress { ID = 1, Street = "123 Main St", City = "Springfield", Province = "IL", PostalCode = "62704" },
                new FullAddress { ID = 2, Street = "456 Oak Ave", City = "Shelbyville", Province = "IL", PostalCode = "62705" },
                new FullAddress { ID = 3, Street = "123 Rav St", City = "Soccer", Province = "IL", PostalCode = "532344" },
                new FullAddress { ID = 4, Street = "123 Abbe St", City = "Basketball", Province = "IL", PostalCode = "112484" },
                new FullAddress { ID = 5, Street = "123 Eric St", City = "goodluck", Province = "IL", PostalCode = "125404" },
                new FullAddress { ID = 6, Street = "123 Claire St", City = "Bye", Province = "IL", PostalCode = "22304" },
                new FullAddress { ID = 7, Street = "123 Lex St", City = "Hi", Province = "IL", PostalCode = "85704" },
                new FullAddress { ID = 8, Street = "123 Ryan St", City = "Goodbye", Province = "IL", PostalCode = "45404" },
                new FullAddress { ID = 9, Street = "123 Noah St", City = "BCIT", Province = "IL", PostalCode = "35204" },
                new FullAddress { ID = 10, Street = "123 Nolan St", City = "OS", Province = "IL", PostalCode = "75404" },
                new FullAddress { ID = 11, Street = "123 Rahim St", City = "Practice", Province = "IL", PostalCode = "20504" },
                new FullAddress { ID = 12, Street = "123 Graves St", City = "LOL", Province = "IL", PostalCode = "02204" },
                new FullAddress { ID = 133, Street = "789 Pine Rd", City = "Capital City", Province = "IL", PostalCode = "62706" }
            );

            modelBuilder.Entity<FullName>().HasData(
                new FullName { Id = 1, FirstName = "John", LastName = "Doe" },
                new FullName { Id = 2, FirstName = "Jane", LastName = "Smith" },
                new FullName { Id = 3, FirstName = "Alice", LastName = "Johnson" },
                new FullName { Id = 4, FirstName = "whatever", LastName = "yor" },
                new FullName { Id = 5, FirstName = "you", LastName = "ABC" },
                new FullName { Id = 6, FirstName = "say", LastName = "DEF" },
                new FullName { Id = 7, FirstName = "Iam", LastName = "HIJ" },
                new FullName { Id = 8, FirstName = "better", LastName = "morning" },
                new FullName { Id = 9, FirstName = "than", LastName = "night" },
                new FullName { Id = 10, FirstName = "you", LastName = "dawn" },
                new FullName { Id = 11, FirstName = "sooo", LastName = "Twilight" },
                new FullName { Id = 12, FirstName = "man", LastName = "dummy" },
                new FullName { Id = 13, FirstName = "up", LastName = "data" }
            );

            // Replace dynamic Guid.NewGuid() with hardcoded static GUIDs for Clients.
            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    FullNameId = 1,
                    FullAdressId = 1,
                    Income = 50000,
                    DateOfBirth = new DateTime(1990, 5, 15)
                },
                new Client
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    FullNameId = 2,
                    FullAdressId = 2,
                    Income = 60000,
                    DateOfBirth = new DateTime(1985, 8, 23)
                },
                new Client
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    FullNameId = 3,
                    FullAdressId = 3,
                    Income = 75000,
                    DateOfBirth = new DateTime(1980, 2, 10)
                },
                new Client
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    FullNameId = 4,
                    FullAdressId = 4,
                    Income = 54000,
                    DateOfBirth = new DateTime(1992, 11, 12)
                },
                new Client
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    FullNameId = 5,
                    FullAdressId = 5,
                    Income = 66000,
                    DateOfBirth = new DateTime(1988, 4, 22)
                },
                new Client
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    FullNameId = 6,
                    FullAdressId = 6,
                    Income = 77400,
                    DateOfBirth = new DateTime(1996, 10, 10)
                }
            );

            // Replace dynamic Guid.NewGuid() with hardcoded static GUIDs for Employees.
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    FullNameId = 2,
                    FullAdressId = 2,
                    Salary = 70000,
                    Title = "Developer",
                    DateOfBirth = new DateTime(1988, 3, 12)
                },
                new Employee
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    FullNameId = 3,
                    FullAdressId = 3,
                    Salary = 80000,
                    Title = "Designer",
                    DateOfBirth = new DateTime(1992, 7, 8)
                },
                new Employee
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    FullNameId = 4,
                    FullAdressId = 4,
                    Salary = 70000,
                    Title = "Developer",
                    DateOfBirth = new DateTime(1988, 3, 12)
                },
                new Employee
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-00000000000A"),
                    FullNameId = 5,
                    FullAdressId = 5,
                    Salary = 70000,
                    Title = "Developer",
                    DateOfBirth = new DateTime(1984, 3, 12)
                },
                new Employee
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-00000000000B"),
                    FullNameId = 6,
                    FullAdressId = 6,
                    Salary = 80000,
                    Title = "Designer",
                    DateOfBirth = new DateTime(1995, 7, 8)
                },
                new Employee
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-00000000000C"),
                    FullNameId = 7,
                    FullAdressId = 7,
                    Salary = 70000,
                    Title = "Developer",
                    DateOfBirth = new DateTime(1984, 3, 12)
                },
                new Employee
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-00000000000D"),
                    FullNameId = 8,
                    FullAdressId = 8,
                    Salary = 80000,
                    Title = "Designer",
                    DateOfBirth = new DateTime(1991, 7, 8)
                },
                new Employee
                {
                    ID = Guid.Parse("00000000-0000-0000-0000-00000000000E"),
                    FullNameId = 9,
                    FullAdressId = 9,
                    Salary = 80000,
                    Title = "Designer",
                    DateOfBirth = new DateTime(1990, 7, 8)
                }
            );

            // Replace dynamic Guid.NewGuid() with hardcoded static GUIDs for Services.
            modelBuilder.Entity<Service>().HasData(
                new Service { ID = Guid.Parse("11111111-1111-1111-1111-111111111111"), Name = "Consulting" },
                new Service { ID = Guid.Parse("22222222-2222-2222-2222-222222222222"), Name = "Development" },
                new Service { ID = Guid.Parse("33333333-3333-3333-3333-333333333333"), Name = "Marketing" },
                new Service { ID = Guid.Parse("44444444-4444-4444-4444-444444444444"), Name = "Marketing" },
                new Service { ID = Guid.Parse("55555555-5555-5555-5555-555555555555"), Name = "Shoplifting" },
                new Service { ID = Guid.Parse("66666666-6666-6666-6666-666666666666"), Name = "shoort" },
                new Service { ID = Guid.Parse("77777777-7777-7777-7777-777777777777"), Name = "Icecream" },
                new Service { ID = Guid.Parse("88888888-8888-8888-8888-888888888888"), Name = "Love" },
                new Service { ID = Guid.Parse("99999999-9999-9999-9999-999999999999"), Name = "Milking" },
                new Service { ID = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), Name = "walking dogs" },
                new Service { ID = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), Name = "Development" },
                new Service { ID = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"), Name = "Marketing" },
                new Service { ID = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"), Name = "Consulting" },
                new Service { ID = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), Name = "Development" },
                new Service { ID = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"), Name = "Marketing" }
            );
        }
    }
}
