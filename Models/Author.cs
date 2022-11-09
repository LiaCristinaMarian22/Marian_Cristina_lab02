using System.ComponentModel.DataAnnotations;

namespace Marian_Cristina_lab02.Models
{
    public class Author
    {
            public int ID { get; set; }
            public String FirstName { get; set; }
            public String LastName { get; set; }

            [Display(Name = "Full Name")]
            public string FullName
            {
               get
               {
                   return FirstName + " " + LastName;
               }
            }
            public ICollection<Book>? Books { get; set; }
    }
}
