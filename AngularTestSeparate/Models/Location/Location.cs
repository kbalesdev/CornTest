using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularTestSeparate.Models.Location
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string LocationName { get; set; }

        public City City { get; set; }
    }
}