using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Internet_Photo_Album.Models
{
    public class PhotosModel
    {
        public UserModel ChosenUser { get; set; }
        public IEnumerable<PhotoModel> Photos { get; set; }
        public PhotoModel CurrentPhoto { get; set; }
        public IEnumerable<RatingModel> CurrentPhotoRatings { get; set; }
        public int? RatingOfCurrentUser { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}