using Sho3lah.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sho3lah.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime PublishDate { get; set; }
        public BookCategory BOOKCategory { get; set; }



        //RelationShips
        public List<Author_Book> Author_Book { get; set; }

    }
}
