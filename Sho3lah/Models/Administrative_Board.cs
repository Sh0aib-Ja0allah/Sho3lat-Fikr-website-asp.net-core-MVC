using Sho3lah.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sho3lah.Models
{
    public class Administrative_Board
    {
        [Keyless]
        public int Administrative_BoardID { get; set; }
        public Boards Boards { get; set; }
        public List<Member> Member { get; set; }

    }
}
