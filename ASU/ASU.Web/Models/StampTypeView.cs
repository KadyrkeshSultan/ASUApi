using System.ComponentModel.DataAnnotations;

namespace ASU.Web.Models
{
    public class StampTypeView
    {
        public int Id { get; set; }
        
        [Required]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        [MinLength(1)]
        public string Desc { get; set; }
    }
}
