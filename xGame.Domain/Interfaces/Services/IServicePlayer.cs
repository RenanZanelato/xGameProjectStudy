using System;
using System.Collections.Generic;
using xGame.Domain.Arguments.Player;
using xGame.Domain.Entities;

namespace xGame.Domain.Interfaces.Services
{
    public interface IServicePlayer
    {
        AuthPlayerResponse AuthPlayer(AuthPlayerRequest request);

        AddingPlayerResponse AddingPlayer(AddingPlayerRequest request);

        AlterPlayerResponse AlterPlayer(AlterPlayerRequest request);

        IEnumerable<PlayerResponse> ListPlayers();
    }
}
