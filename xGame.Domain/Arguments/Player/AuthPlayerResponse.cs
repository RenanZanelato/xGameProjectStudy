using xGame.Domain.Interfaces.Arguments;
using xGame.Domain.ValueObjects;

namespace xGame.Domain.Arguments.Player
{
    public class AuthPlayerResponse : IResponse
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
    }
}
