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
            
            return _repositoryPlayer.AuthPlayer(player.Email.Endereco,player.Password);

        }

        public AddingPlayerResponse AddingPlayer(AddingPlayerRequest request)
        {
            Email email = new Email(request.Email);
            Name name = new Name(request.Name, request.Name);
            Player player = new Player(name,email, request.Password);

            Guid idPlayer = _repositoryPlayer.AddingPlayer(player);
            return new AddingPlayerResponse() { Id = idPlayer, Message = "Operacao Realizada com Sucesso" };
        }
    }
}
