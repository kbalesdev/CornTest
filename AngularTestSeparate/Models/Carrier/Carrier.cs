using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularTestSeparate.Models.Carrier
{
    public class Carrier
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CarrierCode { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string CarrierName { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string McNumber { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string CarrierPhone { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string DispatcherName { get; set; }
    }
}