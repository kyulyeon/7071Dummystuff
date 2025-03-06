using System.ComponentModel.DataAnnotations.Schema;

namespace _7071Midterm_Study.Model
{
    [Table("Clients")]
    public class Client: Person
    {
        public Client()
        {
            this.Services = new
            HashSet<Service>();
        }
        public int Income { get; set; }
        public virtual ICollection<Service>  Services { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

    }
}

