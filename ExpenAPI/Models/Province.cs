using System.ComponentModel.DataAnnotations;

namespace ExpenAPI.Models
{
    public class Province
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
