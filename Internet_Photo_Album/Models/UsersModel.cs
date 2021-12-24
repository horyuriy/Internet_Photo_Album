using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Internet_Photo_Album.Models
{
    public class UsersViewModel
    {
        public IEnumerable<UserModel> Users { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}