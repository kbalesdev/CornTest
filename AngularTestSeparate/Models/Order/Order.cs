using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AngularTestSeparate.Models.Order
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderNumber { get; set; }

        [Required]
        public int LegNumber { get; set; }

        public List<Stop.Stop> Stops { get; set; }

        public Carrier.Carrier Carrier { get; set; }
    }
}