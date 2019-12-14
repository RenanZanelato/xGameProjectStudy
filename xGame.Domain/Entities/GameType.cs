using System;

namespace xGame.Domain.Entities
{
    public class GameType
    {
        public Guid Id { get; set; }
        public Game Game { get; set; }
        public Type Type { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
