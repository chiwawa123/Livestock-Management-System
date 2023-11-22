using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivestockMgmt.Models
{
    [Table("farmers")]
    public class Farmer
    {
        [Key]

        [Column("farmer_id")]
        public int farmer_id { get; set; }

        [Column("first_name")]
        public string first_name { get; set; }

        [Column("surname")]
        public string surname { get; set; }

        [Column("middle_name")]
        public string middle_name { get; set; }

        [Column("contact_number")]
        public string contact_number { get; set; }

        [Column("email")]
        public string email { get; set; }

        [Column("id_number")]
        public string id_number { get; set; }

        [Column("user_id")]
        public int user_id { get; set; }


    }
}
