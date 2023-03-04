using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MINAPharm_task1.Models.Data
{
    [Table("MINAPHARM_ASSETS")]
    public class Assets
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 assitId { get; set; }

        [Required]
        [StringLength (20 , MinimumLength =3,ErrorMessage ="must be more than 3 chars") ]
        public string assetname { set; get; }

        public string owner { set; get; }
        public string processor { set; get; }
        public string installesmomory { set; get; }
        public string manufacturer { set; get; }
        public string model { set; get; }

        public string version { set; get; }
       
        public string drivername { set; get; }

        public int? year { set; get; }


    }
}
