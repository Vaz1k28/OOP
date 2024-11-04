using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
    }

    public class UserManager
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void RemoveUser(int userId)
        {
            users.RemoveAll(user => user.id == userId);
        }

        public User GetUserById(int userId)
        {
            return users.FirstOrDefault(user => user.id == userId);
        }

        public void PrintAllUsers()
        {
            foreach (var user in users)
            {
                Console.WriteLine($"Id: {user.id}, Name: {user.Name}");
            }
        }
    }
}
