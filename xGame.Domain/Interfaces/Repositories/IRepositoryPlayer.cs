using System;
using xGame.Domain.Arguments.Player;

namespace xGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryPlayer
    {
        AuthPlayerResponse AuthPlayer(AuthPlayerRequest request);

        Guid AddingPlayer(Player player);
    }
}
