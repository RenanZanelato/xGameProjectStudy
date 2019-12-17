using System;
using xGame.Domain.Arguments.Player;
using xGame.Domain.Entities;

namespace xGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryPlayer
    {
        Player AuthPlayer(string email,string password);

        Player AddingPlayer(Player player);
    }
}
