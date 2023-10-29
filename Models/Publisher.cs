using MvcGame.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcGame.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Required]
        [ValidateRating]
        public string Rating { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Country { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
