using Sho3lah.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sho3lah.Models
{
    public class Member
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
        public int MemberID { get; set; }
        //RelationShips
        public Boards Boards { get; set; }
    }
}
