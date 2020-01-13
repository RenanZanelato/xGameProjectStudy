using System;
using xGame.Domain.Entities.Base;

namespace xGame.Domain.Entities
{
    public class MyGames : EntityBase
    {
        public GameType GameType { get; set; }
        public bool Wish { get; set; }
        public bool Trade { get; set; }
        public bool Sell { get; set; }
        public DateTime DateWish { get; set; }
    }
}
