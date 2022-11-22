using System.Collections.Generic;

namespace Core.Domain
{
    public class User
    {
        public User()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int GenderId { get; set; }


        public Gender Gender { get; set; }
    }
}
