using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sho3lah.Models
{
    public class Author
    {
        [Display(Name = "ProFile Picture")]
        public string ProFilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Education")]
        public string Education { get; set; }
        [Key]
        public int AuthorID { get; set; }
        //RelationShips
        public List<Author_Book> Author_Book { get; set; }


    }

    public class Authors_Books
    {
        internal object Book;
        internal object Author;
    }
}
