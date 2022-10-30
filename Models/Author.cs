namespace Marian_Cristina_lab02.Models
{
    public class Author
    {
            public int ID { get; set; }
            public int FirstName { get; set; }
            public int LastName { get; set; }
            public ICollection<Book>? Books { get; set; }
    }
}
