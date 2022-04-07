using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballScore.Models
{
    public class AddBaseballModel
    {
        [Required]
        public string HomeTeamName { get; set; }
        [Required]
        public string GuestTeamName { get; set; }
        [Required]
        public string GameTitle { get; set; }
        [Required]
        public int FinalInning { get; set; }

    }
}
