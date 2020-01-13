using prmToolkit.NotificationPattern;
using System;

namespace xGame.Domain.Entities.Base
{
    public abstract class EntityBase : Notifiable
    {
        public Guid Id { get; private set; }
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }
    }
}