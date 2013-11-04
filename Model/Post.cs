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
    public class Post
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [AllowHtml]
        [MaxLength(100)]
        public string Content { get; set; }

        [Required]
        public DateTime Date { get; set; }

        //Navigations properties
        public int UserProfileId { get; set; }
        [Required]
        public virtual UserProfile UserProfile { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
