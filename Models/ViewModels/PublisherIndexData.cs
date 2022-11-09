using Marian_Cristina_lab02.Models;

namespace Marian_Cristina_lab02.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
