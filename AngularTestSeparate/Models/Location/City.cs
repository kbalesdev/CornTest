using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularTestSeparate.Models.Location
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string CityName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string State { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string ZipCode { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string CountryCode { get; set; }
    }
}