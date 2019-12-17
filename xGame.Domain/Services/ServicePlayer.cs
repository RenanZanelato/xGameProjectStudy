using prmToolkit.NotificationPattern;
using System;
using xGame.Domain.Arguments.Player;
using xGame.Domain.Entities;
using xGame.Domain.Interfaces.Repositories;
using xGame.Domain.Interfaces.Services;
using xGame.Domain.ValueObjects;
namespace xGame.Domain.Services
{
    public class ServicePlayer : Notifiable, IServicePlayer
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
                AddNotification("AuthPlayerRequest", "AuthPlayerRequest is required");
            }
            Email email = new Email(request.Email);

            Player player = new Player(email, request.Password);

            AddNotifications(player, email);
            if (player.IsInvalid())
            {
                return null;
            }
            
            player =_repositoryPlayer.AuthPlayer(player.Email.Endereco,player.Password);

            return new AuthPlayerResponse
            {
                FirstName = player.Name.FirstName,
                Email = player.Email.Endereco,
                Status =(int)player.Status
            };

        }

        public AddingPlayerResponse AddingPlayer(AddingPlayerRequest request)
        {
            Email email = new Email(request.Email);

            Name name = new Name(request.FirstName, request.LastName);
            Player player = new Player(name,email, request.Password);
            if (player.IsInvalid())
            {
                return null;
            }
            Guid idPlayer = _repositoryPlayer.AddingPlayer(player);
            return new AddingPlayerResponse() { Id = idPlayer, Message = "Operacao Realizada com Sucesso" };
        }
    }
}
