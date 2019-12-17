using xGame.Domain.Interfaces.Arguments;
using xGame.Domain.ValueObjects;

namespace xGame.Domain.Arguments.Player
{
    public class AddingPlayerRequest : IRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
