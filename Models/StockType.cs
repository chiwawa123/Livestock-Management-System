using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivestockMgmt.Models
{
    [Table("StockTypes")]
    public class StockType
    {
        [Key]
        [Column("stock_type_id")]
        public int stock_type_id { get; set; }
        [Column("stock_type")]
        public string stock_type { get; set; }
    }
}
