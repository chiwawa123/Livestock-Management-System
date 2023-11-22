using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LivestockMgmt.Models
{
    [Table("stockstates")]
    public class StockState
    {

        [Key]

        [Column("stock_state_id")]
        public int stock_state_id { get; set; }

        [Column("created_at")]
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly created_at { get; set; }

        [Column("updated_at")]
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly updated_at { get; set; }

        [Column("stock_state")]
        public string stock_state { get; set; }

        [Column("state_description")]
        public string state_description { get; set; }

        [Column("livestock_id")]
        public int livestock_id { get; set; }



    }
}
