using System.ComponentModel.DataAnnotations;

namespace ExpenAPI.Models
{
    public class Owner
    {
        public int Id { get; set; }

        [Required]
        public int BuildingId { get; set; }

        [Required]
        public string FullName { get; set; }

        public string CellphoneNumber { get; set; }
        
        [Required]
        public string Apartment { get; set; }

        [Required]
        public float SquareMtsApartment { get; set; }

        public float SquareMtsGarage { get; set; }

        public virtual Building Building { get; set; }
    }
}
