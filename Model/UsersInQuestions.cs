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
    public class UsersInQuestions
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }
        [Required]
        public virtual Question Question { get; set; }

        public int UserId { get; set; }
        [Required]
        public virtual UserProfile User { get; set; }
    }
}
