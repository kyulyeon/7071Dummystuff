using _7071Midterm_Study.Data;
using _7071Midterm_Study.Model;
using Microsoft.AspNetCore.Mvc;

namespace _7071Midterm_Study.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WeatherForecastController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public Client Post()
        {
            var c = new Client
            {
                Name = new FullName { FirstName = "Eric", LastName = "Long" },
                Address = new FullAddress { Street = "123 Main St", City = "Sample City", Province = "State", PostalCode = "12345" },
                Services = new List<Service>()
            };

            var service = new Service
            {
                Name = "Premium Service",
                Rate = 100
            };

            _context.Services.Add(service);
            _context.Clients.Add(c);
            _context.SaveChanges();

            return c;
        }
    }
}
