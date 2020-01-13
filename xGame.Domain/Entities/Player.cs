using prmToolkit.NotificationPattern;
using System;
using xGame.Domain.Entities.Base;
using xGame.Domain.Enum;
using xGame.Domain.Extensions;
using xGame.Domain.ValueObjects;

namespace xGame.Domain.Entities
{
    public class Player : EntityBase
    {
        public Name Name { get; private set; }
        public string Password { get; private set; }
        public Email Email { get; private set; }
        public EnumStatusPlayer Status { get; private set; }
        public Player(Email email, string password)
        {
            Email = email;
            Password = password;

            new AddNotifications<Player>(this)
                .IfNullOrInvalidLength(x => x.Password, 6, 32, "Min Lenght 6 and Max Lenght 32")
                ;

        }
        public Player(Name name,Email email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            Status = Enum.EnumStatusPlayer.InProgress;

            new AddNotifications<Player>(this)
                .IfNullOrInvalidLength(x => x.Password, 6, 32, "Min Lenght 6 and Max Lenght 32")
                ;

            AddNotifications(name, email);
            if (IsValid()) 
            {
                Password = Password.ConverTToMD5();
            }
        }
        public void AlterPlayer(Name name, Email email, EnumStatusPlayer status = Enum.EnumStatusPlayer.Active)
        {
            Name = name;
            Email = email;
            

            new AddNotifications<Player>(this)
                .IfFalse(Status == EnumStatusPlayer.Active,"Só é possivel alterar jogador se ele estiver ativo")
                ;

            AddNotifications(name, email);
            if (IsValid())
            {
                Status = status;
            }
        }
    }
}
