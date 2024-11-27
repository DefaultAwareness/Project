using System;

namespace Lastname_Project
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public User(int userId, string userName, string email)
        {
            UserId = userId;
            UserName = userName;
            Email = email;
        }

        public void Login()
        {
            Console.WriteLine($"{UserName} has logged in.");
        }

        public void Logout()
        {
            Console.WriteLine($"{UserName} has logged out.");
        }

        public override string ToString()
        {
            return $"User ID: {UserId}, Name: {UserName}, Email: {Email}";
        }
    }
}
