using System;
using xGame.Domain.Entities.Base;

namespace xGame.Domain.Entities
{
    public class GameType : EntityBase
    {
        public Game Game { get; set; }
        public Type Type { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
