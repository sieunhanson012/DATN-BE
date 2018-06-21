using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DATN_BackEnd.Models.Entities
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public int status { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_updated { get; set; }

        public virtual ICollection<NewsType> NewsTypes { get; set; }
    }
}