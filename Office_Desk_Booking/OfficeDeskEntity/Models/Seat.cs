using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskEntity.Models
{
    [Table("seats")]
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }
        public string SeatNumber { get; set; }

        public Floor Floor { get; set; }
    }
}
