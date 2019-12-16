using System;
using xGame.Domain.Enum;
using xGame.Domain.ValueObjects;

namespace xGame.Domain.Entities
{
    public class Player
    {
        public Player(string password, Email email)
        {
            Password = password;
            Email = email;

            if (string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Email is required");
            }
            if (string.IsNullOrEmpty(request.Password))
            {
                throw new Exception("Password is required");
            }
        }

        public Guid Id { get; set; }
        public Name Name { get; set; }
        public string Password { get; set; }
        public Email Email { get; set; }
        public EnumStatusPlayer Status { get; set; } 
    }
}
