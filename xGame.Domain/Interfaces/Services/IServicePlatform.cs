using System;
using xGame.Domain.Arguments.Platform;

namespace xGame.Domain.Interfaces.Services
{
    public interface IServicePlatform
    {
        AddingPlatformResponse AddingPlatform(AddingPlatformRequest request);

    }
}
