using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AngularTestSeparate.Models.Enums;

namespace AngularTestSeparate.Models.Stop
{
    public class Stop
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StopSequence { get; set; }
        
        public StopTypes StopTypeId { get; set; }
        public virtual StopType StopType { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string RefNumber { get; set; }

        public DateTime EarliestAppointment { get; set; }

        public DateTime LatestAppointment { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime DepartureTime { get; set; }

        public Location.Location Location { get; set; }
    }
}