using System.ComponentModel.DataAnnotations;

namespace ExpenAPI.Models
{
    public class Building
    {
        public int Id { get; set; }
        public int CaretakerId { get; set; }

        [Required]
        public int CityId { get; set; }
        
        [Required]
        public string Address { get; set; }
        
        [Required]
        public bool Helpers { get; set; }

        [Required]
        public bool SecurityGuars { get; set; }

        [Required]
        public float SquareMts { get; set; }

        [Required]
        public float SquareMtsGarages { get; set; }

        public string Comments { get; set; }

        
        public virtual Caretaker Caretaker { get; set; }
        public virtual City City { get; set; }
    }
}
