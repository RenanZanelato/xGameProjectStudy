using System;
using xGame.Domain.Entities;
using xGame.Domain.Interfaces.Arguments;

namespace xGame.Domain.Arguments.Player
{
    public class AddingPlayerResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }

        public static explicit operator AddingPlayerResponse(Entities.Player v)
        {
            return new AddingPlayerResponse() { Id = v.Id, Message = "Operacao Realizada com Sucesso" };
        }
    }
}
