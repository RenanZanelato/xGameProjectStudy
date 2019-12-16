using xGame.Domain.Interfaces.Arguments;
using xGame.Domain.ValueObjects;

namespace xGame.Domain.Arguments.Player
{
    public class AddingPlayerRequest : IRequest
    {
        public Name Name { get; set; }
        public Email Email { get; set; }
        public string Password { get; set; }
    }
}
