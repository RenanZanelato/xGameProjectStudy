using System;
using xGame.Domain.Interfaces.Arguments;

namespace xGame.Domain.Arguments.Player
{
    public class AddingPlayerResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
    }
}
