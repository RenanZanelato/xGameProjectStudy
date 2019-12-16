using System;
using xGame.Domain.Arguments.Player;
using xGame.Domain.Entities;

namespace xGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryPlayer
    {
        AuthPlayerResponse AuthPlayer(string email,string password);

        Guid AddingPlayer(Player player);
    }
}
