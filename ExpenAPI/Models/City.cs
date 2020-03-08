using System.ComponentModel.DataAnnotations;

namespace ExpenAPI.Models
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int ProvinceId { get; set; }

        public virtual Province Province { get; set; }

    }
}
