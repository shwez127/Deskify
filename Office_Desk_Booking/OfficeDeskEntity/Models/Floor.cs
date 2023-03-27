using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskEntity.Models
{
    [Table("floors")]
    public class Floor
    {
        [Key]
        public int FloorId { get; set; }
        public string FloorName { get; set; }
        public ICollection<Seat> Seats { get; set; }
        
       
    }
}
