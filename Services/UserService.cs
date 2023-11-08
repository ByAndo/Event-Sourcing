using Nh.Example.Domain.Models;
using Nh.Example.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nh.Example.Domain.Services
{
    public class UserService
    {
        private UserRepository repository;

        public UserService(UserRepository repository)
        {
            this.repository = repository;
        }

        public void CreateUser(string userId, string firstName, string lastName)
        {
            User user = new User(userId, firstName, lastName);
            repository.AddUser(userId, user);
        }

        public void UpdateUser(string userId, HashSet<Contact> contacts, HashSet<Address> addresses)
        {
            User user = repository.GetUser(userId);
        }

        public HashSet<Contact> GetContactByType(string userId, string contactType)
        {
            User user = repository.GetUser(userId);
            HashSet<Contact> contacts = user.Contacts;
            return contacts.Where(w => w.Type.Equals(contactType))
                .ToHashSet<Contact>();
        }

        public HashSet<Address> GetAddressesByRegion(string userId, string state)
        {
            User user = repository.GetUser(userId);
            HashSet<Address> addresses = user.Address;
            return addresses.Where(w => w.State.Equals(state))
                .ToHashSet<Address>();
        }
    }
}
