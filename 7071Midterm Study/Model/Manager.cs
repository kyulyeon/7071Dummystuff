using System.ComponentModel.DataAnnotations.Schema;

namespace _7071Midterm_Study.Model
{
    [Table("Manager")]
    public class Manager: Employee
    {
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
