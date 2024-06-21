using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HVPBAiTHILAI.Models
{
    [Table("Person")]
    public class HVP500Person
    {
        [Key]
        public string? PersonId { get; set; }
        public int? Nhom {get; set;}
        public double? MVS { get; set; }

    }

}