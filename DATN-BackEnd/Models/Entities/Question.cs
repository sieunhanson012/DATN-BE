using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DATN_BackEnd.Models.Entities
{
    [Table("Question")]
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("AnswerType")]
        public int answer_type { get; set; }

        [Required]
        public string name { get; set; }

        public bool status { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_updated { get; set; }

        public virtual AnswerType AnswerType { get; set; }
    }
}