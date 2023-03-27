using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskEntity.Models
{
    [Table("qrscanners")]
    public class QRScanner
    {
        [Key]
        public int QId { get; set; }
        public byte[] QRCode { get; set; }

        [ForeignKey("BookingSeat")]
        public int BookingSeatId { get; set; }
        public BookingSeat BookingSeat { get; set; }
    }
}
