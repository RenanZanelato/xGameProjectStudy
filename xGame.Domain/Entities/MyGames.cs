using System;

namespace xGame.Domain.Entities
{
    public class MyGames
    {
        public Guid Id { get; set; }
        public GameType GameType { get; set; }
        public bool Wish { get; set; }
        public bool Trade { get; set; }
        public bool Sell { get; set; }
        public DateTime DateWish { get; set; }
    }
}
