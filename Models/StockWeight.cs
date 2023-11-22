using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LivestockMgmt.Models
{
    [Table("stockweights")]
    public class StockWeight
    {
        [Key]
        [Column("stock_weight_id")]
        public int stock_weight_id { get; set; }
        [Column("stock_id")]
        public int stock_id { get; set; }
        [Column("date_recorded")]
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly date_recorded { get; set; }
    }
}
