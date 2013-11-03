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
    public class QuestionsInTags
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }
        [Required]
        public virtual Question Question { get; set; }

        public int TagId { get; set; }
        [Required]
        public virtual Tag Tag { get; set; }
    }
}
