using System.ComponentModel.DataAnnotations.Schema;

namespace _7071Midterm_Study.Model
{
    public class Service
    {
        public Service()
        {
            this.Clients = new
            HashSet<Client>();
            this.Employees = new
            HashSet<Employee>();
        }
        public Guid ID { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public int Rate { get; set; }
        public virtual ICollection<Client>      Clients        { get; set; }
        public virtual ICollection<Employee>        Employees        { get; set; }
    }
}
