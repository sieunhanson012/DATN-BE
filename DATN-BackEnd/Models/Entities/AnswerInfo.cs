using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DATN_BackEnd.Models.Entities
{

    [Table("AnswerInfo")]
    public class AnswerInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public bool status { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_updated { get; set; }

        public virtual ICollection<AnswerType> AnswerType { get; set; }

    }
}