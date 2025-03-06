using System.ComponentModel.DataAnnotations.Schema;

namespace _7071Midterm_Study.Model
{
    [Table("FullName")]
    public class FullName
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName {  get; set; }
    }
}
