using Core.Domain;
using System.Collections.Generic;

namespace Web.Models
{
    public class UserViewModel
    {
        public IEnumerable<Gender> Genders { get; set; } = new List<Gender>();

        public IEnumerable<User> Users { get; set; } = new List<User>();
    }
}
