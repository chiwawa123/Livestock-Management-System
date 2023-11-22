using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LivestockMgmt.Models
{
    [Table("livestocks")]
    public class Livestock
    {
        [Key]

        [Column("stock_id")]
        public int stock_id { get; set; }

        [Column("stock_type_id")]
        public int stock_type_id { get; set; }

        [Column("dob")]
        public DateOnly dob { get; set; }

        [Column("sex")]
        public string sex { get; set; }

        [Column("colors")]
        public string colors { get; set; }

        [Column("picture_path")]
        public string picture_path { get; set; }

        [Column("farm_id")]
        public int farm_id { get; set; }

        [Column("farmer_id")]
        public int farmer_id { get; set; }
        [Column("tag_number")]
        public string tag_number { get; set; }
    }
}
