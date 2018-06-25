using System.ComponentModel.DataAnnotations;

namespace ASU.Web.Models
{
    public class MeasurementTypeView
    {
        public string Id { get; set; }

        [Required]
        [MinLength(1)]
        public string Name { get; set; }
    }
}
