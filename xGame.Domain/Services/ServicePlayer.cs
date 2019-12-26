using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public ServicePlayer()
        {
        }

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
                        
            return (AuthPlayerResponse) _repositoryPlayer.AuthPlayer(player.Email.Endereco, player.Password);

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
            return (AddingPlayerResponse) _repositoryPlayer.AddingPlayer(player) ;
        }

        public PlayerResponse AlterPlayer(AlterPlayerRequest request)
        {
            if (request == null)
            {
                AddNotification("AuthPlayerRequest", "AuthPlayerRequest is required");
            }
            Player player = _repositoryPlayer.GetPlayerToId(request.Id);

            if (player == null) 
            {
                AddNotification("Player", "Player don't exist");
                return null;
            }
            Email email = new Email(request.Email);
            Name name = new Name(request.FirstName, request.LastName);

            if (IsInvalid()) 
            {
                return null;
            }
            player.AlterPlayer(name, email,player.Status);
            _repositoryPlayer.AlterPlayer(player);

            return (PlayerResponse)player; 

        }

        public IEnumerable<PlayerResponse> ListPlayers()
        {
            return _repositoryPlayer.ListPlayers().ToList().Select(player => (PlayerResponse)player).ToList();
        }

    }
}
