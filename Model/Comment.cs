using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Web.Mvc;

namespace Model
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int UserProfileId { get; set; }
        [Required]
        public virtual UserProfile UserProfile { get; set; }

        public int PostId { get; set; }
        [Required]
        public virtual Post Post { get; set; }
    }
}
