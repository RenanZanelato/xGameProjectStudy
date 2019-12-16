using xGame.Domain.Interfaces.Arguments;
using xGame.Domain.ValueObjects;

namespace xGame.Domain.Arguments.Player
{
    public class AuthPlayerResponse : IResponse
    {   
        public Name Name { get; set; }
    }
}
