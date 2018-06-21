using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DATN_BackEnd.Models.Entities
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }

        public int status { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_updated { get; set; }
    }
}