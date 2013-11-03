using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Model
{
    public class AnswerRating
    {
        public int Id { get; set; }

        public int AnswerId { get; set; }
        [Required]
        public virtual Answer Answer { get; set; }

        public int UserId { get; set; }
        [Required]
        public virtual UserProfile User { get; set; }

        [Required]
        public bool Rate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTimeOffset CreationDate { get; set; }
    }
}
