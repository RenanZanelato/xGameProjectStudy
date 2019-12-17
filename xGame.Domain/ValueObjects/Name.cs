using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace xGame.Domain.ValueObjects
{
    public class Name : Notifiable
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            new AddNotifications<Name>(this)
                .IfNullOrInvalidLength(x => x.FirstName,0,25, "Name Invalid")
                .IfNullOrInvalidLength(x => LastName,0,25, "lastName invalid");

        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
