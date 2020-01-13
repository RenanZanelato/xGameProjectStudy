using System;
using xGame.Domain.Entities;
using xGame.Domain.Interfaces.Repositories;
using xGame.Infra.Persistence.Repositories.Base;

namespace xGame.Infra.Persistence.Repositories
{
    public class RepositoryPlayer: RepositoryBase<Player, Guid>,IRepositoryPlayer
    {
        protected readonly XGameContext _context;
        public RepositoryPlayer(XGameContext context) : base(context)
        {
            _context = context;
        }

    }
}
