using xGame.Domain.Interfaces.Arguments;

namespace xGame.Domain.Arguments.Player
{
    public class AuthPlayerRequest : IResponse
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
