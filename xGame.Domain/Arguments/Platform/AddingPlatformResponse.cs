using System;
using xGame.Domain.Interfaces.Arguments;

namespace xGame.Domain.Arguments.Platform
{
    public class AddingPlatformResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
