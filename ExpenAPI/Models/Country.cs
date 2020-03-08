using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExpenAPI.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<Province> Provinces { get; set; }
    }
}
