using System;
using xGame.Domain.Enum;
using xGame.Domain.ValueObjects;

namespace xGame.Domain.Entities
{
    public class Player
    {
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public string Password { get; set; }
        public Email Email { get; set; }
        public EnumStatusPlayer Status { get; set; } 
    }
}
