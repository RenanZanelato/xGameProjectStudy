using System;
using xGame.Domain.Entities.Base;

namespace xGame.Domain.Entities
{ 
    public class Game : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Producer { get; set; }
        public string Distributor { get; set; }
        public string Genre { get; set; }
        public string Site { get; set; }
    } 
}
