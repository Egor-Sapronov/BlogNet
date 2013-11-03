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
    public class Answer
    {
        public int Id { get; set; }

        [Required]
        [AllowHtml]
        public string Content { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTimeOffset CreationDate { get; set; }

        public virtual ICollection<UsersInAnswers> UsersInAnswers { get; set; }
        public virtual ICollection<AnswerRating> AnswerRating { get; set; }
    }
}
