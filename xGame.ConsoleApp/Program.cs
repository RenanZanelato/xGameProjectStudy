using System;
using xGame.Domain.Interfaces.Services;
using xGame.Domain.Services;
using xGame.Domain.Arguments.Player;
using System.Linq;

namespace xGame.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            ServicePlayer service = new ServicePlayer();
            Console.WriteLine("Creating Service Player");
            AuthPlayerRequest request = new AuthPlayerRequest();
            Console.WriteLine("Creating Auth Player");

            request.Email = "renan.zanelato@gmail.com";
            request.Password = "teste123";

            Console.WriteLine(request);
            Console.WriteLine(request.Email);
            Console.WriteLine(request.Password);

            AddingPlayerRequest request2 = new AddingPlayerRequest();
            request2.Email = request.Email;
            request2.Password = request.Password;
            request2.FirstName = "Renan";
            request2.LastName = "Zanelato";

            service.AddingPlayer(request2);

            service.AuthPlayer(request);

            Console.WriteLine("isValid ->" + service.IsValid() );

            if (!service.IsValid())
            {
                service.Notifications.ToList().ForEach(x =>
                {
                    Console.WriteLine(x.Message);
                });
            }

            Console.ReadKey();
        }
    }
}
