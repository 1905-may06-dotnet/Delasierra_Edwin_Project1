using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void DeleteUser(string username);
        void EditUser(User user);
        IEnumerable<User> GetAllUsers();
        User GetUser(string username);
        void Save();
    }
}
