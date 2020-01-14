using xGame.Domain.Arguments.Platform;
using xGame.Domain.Interfaces.Services.Base;

namespace xGame.Domain.Interfaces.Services
{
    public interface IServicePlatform : IServiceBase
    {
        AddingPlatformResponse AddingPlatform(AddingPlatformRequest request);
    }
}
