using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DATN_BackEnd.Models.Entities
{
    [Table("AnswerType")]
    public class AnswerType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("TestType")]
        public int test_type_id { get; set; }

        [ForeignKey("AnswerInfo")]
        public int answer_info_id { get; set; }

        [Required]
        public string name { get; set; }

        public bool status { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_updated { get; set; }

        public virtual TestType TestType { get; set; }

        public virtual AnswerInfo AnswerInfo { get; set; }
    }
}