using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThingsILearned.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Display(Name = "Sub-Heading")]
        public string SubHeading { get; set; }
        public string Description { get; set; }

        public string Author { get; set; }
        [Required]
        [Display(Name = "Created On: ")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [Display(Name ="Last Modified On:")]
        public DateTime LastModified { get; set; }


    }
}