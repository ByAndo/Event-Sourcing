using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nh.Example.Domain.Models
{
    public class User
    {
        public User(string userId, string firstName, string lastName)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
        }

        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public HashSet<Contact> Contacts {get;set;}
        public HashSet<Address> Address { get; set; }

    }
}
