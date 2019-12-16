using System;
using xGame.Domain.Arguments.Player;
using xGame.Domain.Entities;
using xGame.Domain.Interfaces.Repositories;
using xGame.Domain.Interfaces.Services;

namespace xGame.Domain.Services
{
    public class ServicePlayer : IServicePlayer
    {
        private readonly IRepositoryPlayer _repositoryPlayer;

        public ServicePlayer(IRepositoryPlayer repositoryPlayer)
        {
            _repositoryPlayer = repositoryPlayer;
        }
        public AuthPlayerResponse AuthPlayer(AuthPlayerRequest request)
        {
            if (request == null)
            {
                throw new Exception("AuthPlayerRequet is required");
            }
            
            
            return _repositoryPlayer.AuthPlayer(request);

        }

        public AddingPlayerResponse AddingPlayer(AddingPlayerRequest request)
        {
            Player player = new Player(request.Name,request.Email);
            player.Status = Enum.EnumStatusPlayer.Active;

            Guid idPlayer = _repositoryPlayer.AddingPlayer(player);
            return new AddingPlayerResponse() { Id = idPlayer, Message = "Operacao Realizada com Sucesso" };
        }
    }
}
