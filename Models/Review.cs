using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ReviewWebsite.Models
{
    public class Review
    {
      [Key]
       public virtual int Id { get; set; }

        [Required (ErrorMessage = "Please enter Movie Name")]
        public virtual string Review_name { get; set; }

        [Required (ErrorMessage = "Please rate the movie...")]
        public virtual short star { get; set; }

        public virtual string movie_poster { get; set; }

        [Display(Name = "Director")]
        public virtual string director { get; set; }

        [Display(Name = "Publication")]
        public virtual string publications { get; set; }

        [Required (ErrorMessage = "Please describe your rating so others can be benefited.")]
        public virtual string Review_desc { get; set; }

        public Review() {}

        public Review(string name, short rating, string img, string direct, string pub, string desc)
        {
            Review_name = name;
            star = rating;
            movie_poster = img;
            director = direct;
            publications = pub;
            Review_desc = desc;
        }

    }
}