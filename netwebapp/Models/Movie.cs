using System.ComponentModel.DataAnnotations;

namespace netwebapp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)] //sets DateTime type to display as Date
        public DateTime ReleaseDate { get; set; }
        
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
