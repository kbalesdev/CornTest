using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AngularTestSeparate.Models.Enums;

namespace AngularTestSeparate.Models.Stop
{
    public class StopType
    {
        public StopTypes Id { get; set; }

        public string Description { get; set; }
    }
}