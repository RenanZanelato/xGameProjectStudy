using xGame.Domain.Interfaces.Arguments;
using xGame.Domain.ValueObjects;

namespace xGame.Domain.Arguments.Platform
{
    public class AddingPlatformRequest : IRequest
    {
        public string Name { get; set; }
    }
}
