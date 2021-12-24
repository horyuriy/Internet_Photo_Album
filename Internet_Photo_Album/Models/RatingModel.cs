using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Internet_Photo_Album.Models
{
    public class RatingModel
    {
        public int Id { get; set; }
        public int UserRate { get; set; }
        public int PhotoId { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
    }
}