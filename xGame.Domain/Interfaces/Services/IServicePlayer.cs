using System;
using xGame.Domain.Arguments.Player;

namespace xGame.Domain.Interfaces.Services
{
    public interface IServicePlayer
    {
        AuthPlayerResponse AuthPlayer(AuthPlayerRequest request);

        AddingPlayerResponse AddingPlayer(AddingPlayerRequest request);

    }
}
