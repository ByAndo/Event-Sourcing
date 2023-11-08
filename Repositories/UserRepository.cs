using Nh.Example.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nh.Example.Domain.Repositories
{
    public class UserRepository
    {
        public Dictionary<string, User> Store = new Dictionary<string, User>();

        public void AddUser(string userId, User user)
        {
            Store.Add(userId, user);
        }

        public User GetUser(string userId)
        {
            return Store.Where(w => w.Key.Equals(userId))
                .Select(s => s.Value)
                .FirstOrDefault();
        }
    }
}
