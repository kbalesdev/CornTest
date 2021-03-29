using System;
using System.ComponentModel.DataAnnotations;
using AngularTestSeparate.Models.Enums;

namespace AngularTestSeparate.Models.Stop
{
    public class Stop
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StopSequence { get; set; }

        [Required]
        public StopTypes StopType { get; set; }

        public DateTime EarliestAppointment { get; set; }

        public DateTime LatestAppointment { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime DepartureTime { get; set; }

        public Location.Location Location { get; set; }
    }
}