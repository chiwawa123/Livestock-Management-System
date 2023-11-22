using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivestockMgmt.Models
{

    [Table("farms")]
    public class Farm
    {
        [Key]

        [Column("farm_id")]
        public int farm_id { get; set; }

        [Column("farm_name")]
        public string farm_name { get; set; }

        [Column("district")]
        public string Description { get; set; }

        [Column("province")]
        public string province { get; set; }
        [Column("farmer_id")]
        public int farmer_id { get; set; }

        [Column("country")]
        public string country { get; set; }

        [Column("farm_description")]
        public string farm_description { get; set; }

       

    }
}
