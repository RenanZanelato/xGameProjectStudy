using System;
using xGame.Domain.ValueObjects;

namespace xGame.Domain.Entities
{
    public class Player
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Email Email { get; set; }
        public int Status { get; set; } 
    }
}
