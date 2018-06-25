using System.ComponentModel.DataAnnotations;

namespace ASU.Web.Models
{
    public class TestEquipmentView
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        public string Name { get; set; }
        public string Country { get; set; }
        public string ManufactureDate { get; set; }
        public string Model { get; set; }
        public string Producer { get; set; }

        [Required]
        public string WorkNumber { get; set; }
    }
}
