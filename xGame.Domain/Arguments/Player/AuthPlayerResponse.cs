using System;
using xGame.Domain.Entities;
using xGame.Domain.Interfaces.Arguments;
using xGame.Domain.ValueObjects;

namespace xGame.Domain.Arguments.Player
{
    public class AuthPlayerResponse : IResponse
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }

        public static explicit operator AuthPlayerResponse(Entities.Player v)
        {
            return new AuthPlayerResponse
            {
                FirstName = v.Name.FirstName,
                Email = v.Email.Endereco,
                Status = (int)v.Status
            };
        }
    }
}
