using System.ComponentModel.DataAnnotations;

namespace ExpenAPI.Models
{
    public class Caretaker
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public virtual Building Building { get; set; }
    }
}
