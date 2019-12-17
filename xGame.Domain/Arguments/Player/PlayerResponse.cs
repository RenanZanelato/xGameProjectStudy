using System;
using xGame.Domain.Entities;

namespace xGame.Domain.Arguments.Player
{
    public class PlayerResponse
    {
        public Guid Id { get;  set; }
        public string Name { get;  set; }
        public string FirstName { get; set; }
        public string Email { get;  set; }
        public string Status { get;  set; }

        public static explicit operator PlayerResponse(Entities.Player v)
        {
            return new PlayerResponse()
            {
                Email = v.Email.Endereco,
                Name = v.Name.ToString(),
                FirstName = v.Name.FirstName,
                Id = v.Id,
                Status = v.Status.ToString()
            };
        }
    }
}
