using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Internet_Photo_Album.Models
{
    public class PhotoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field can not be empty.")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Image")]
        public byte[] Image { get; set; }

        [Display(Name = "Total rate")]
        public int TotalRate { get; set; }

        public DateTime CreationDate { get; set; }

        public int UserId { get; set; }
    }
}
}