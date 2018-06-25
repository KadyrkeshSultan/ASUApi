using System.ComponentModel.DataAnnotations;

namespace ASU.Web.Models
{
    public class VerificatorView
    {
        public int Id { get; set; }
        public string Address { get; set; }

        [Required]
        [MinLength(1)]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Certificate { get; set; }
        public string Code { get; set; }
        public string Director { get; set; }
    }
}
