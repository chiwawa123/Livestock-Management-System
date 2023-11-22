using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LivestockMgmt.Models
{
    [Table("stockdossages")]
    public class StockDosage
    {
        [Key]

        [Column("stock_dosage_id")]
        public int stock_dosage_id { get; set; }

        [Column("stock_id")]
        public int stock_id { get; set; }

        [Column("dosage_description")]
        public string dosage_description { get; set; }

        [Column("date_posted")]
        public DateOnly date_posted { get; set; }

        [Column("expirydate")]
        public DateOnly expirydate { get; set; }

     
    }
}
