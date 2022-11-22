using System;

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
        public DateTime CreatedDate { get; set; }

        // nav properties.
        public Gender Gender { get; set; }
    }
}
