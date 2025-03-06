using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _7071Midterm_Study.Model
{
    [Table("People")]
    public class Person
    {
        public Guid ID { get; set; }

        public int FullNameId { get; set; }

        [ForeignKey("FullNameId")]
        public FullName Name { get; set; }
       
        public int FullAdressId { get; set; }

        [ForeignKey("FullAdressId")]
        public FullAddress        Address        { get; set; }
        public DateTime        DateOfBirth        { get; set; }

       
    }
}
