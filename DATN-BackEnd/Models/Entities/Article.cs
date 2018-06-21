using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DATN_BackEnd.Models.Entities
{

    [Table("Article")]
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("NewsType")]
        public int news_type_id { get; set; }

        [ForeignKey("Account")]
        public int account_id { get; set; }

        [Column(TypeName ="nvarchar")]
        [Required]
        public string title { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string description { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string content { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string images { get; set; }

        public bool status { get; set; }

        public DateTime date_created { get; set; }
        
        public DateTime date_updated { get; set; }

        public virtual Account Account { get; set; }

        public virtual NewsType NewsType { get; set; }



    }
}