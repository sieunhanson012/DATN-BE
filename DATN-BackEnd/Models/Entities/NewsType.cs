using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DATN_BackEnd.Models.Entities
{

    [Table("NewsType")]
    public class NewsType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("Category")]
        public int category_id { get; set; }

        [Required]
        public string name { get; set; }

        public int status { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_updated { get; set; }

        public virtual Category Category { get; set; }
    }
}