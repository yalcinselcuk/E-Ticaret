using ProductApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Services
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>();
        public UserService()
        {
            _users = new List<User>
            {
                new User(){Id=1, Name="Türkay", Password="123", Email="abc@xyz.com", Role="Admin", UserName="turko"},
                new User(){Id=1, Name="Yalçın", Password="123", Email="abc@xyz.com", Role="Editor", UserName="selçuk"},
                new User(){Id=1, Name="Kerem", Password="123", Email="abc@xyz.com", Role="Client", UserName="yılmazer"}
            };
        }
        public User? ValidateUser(string username, string password)
        {
            return _users.SingleOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
