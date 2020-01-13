using System;
using xGame.Domain.Entities;
using xGame.Domain.Interfaces.Repositories.Base;

namespace xGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryPlayer : IRepositoryBase<Player, Guid>
    {

    }
}
