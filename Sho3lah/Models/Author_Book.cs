using System.ComponentModel.DataAnnotations;

namespace Sho3lah.Models
{
    public class Author_Book
    {
        //Many to many Relationships Table Authors And Books
        [Key]
       public int BookID { get; set; }
       public int AuthorID { get; set; } 
       public Author Author { get; set; }

    }
}
