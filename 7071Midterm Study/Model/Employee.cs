using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace _7071Midterm_Study.Model
{
    [Table("Employee")]
    public class Employee: Person
    {
            public Service MyService;
            public int Salary { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
