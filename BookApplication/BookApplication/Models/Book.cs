
namespace BookApplication.Models
{
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
    public class Book
    {
        public int BookID { get; set; }
        [   Required(ErrorMessageResourceName = "BookID must not be empty."),
            MaxLength(100, ErrorMessage = "BookID must not be longer than 100 characters."),
            DisplayName("Mã sách")]

        public string Title { get; set; }
        [Required]

        public string Description { get; set; }

        public int AuthorID { get; set; }
        [Required]

        public Nullable<int> Price { get; set; }
        

        public Nullable<DateOnly> PublishedDate { get; set; }
        [DataType(DataType.Date)]

        public int Quantity { get; set; } = 1;

        public string[]? Genre { get; set; }
    }
}
