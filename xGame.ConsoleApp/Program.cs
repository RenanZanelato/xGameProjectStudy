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
            /*
            Console.WriteLine("Starting");
            ServicePlayer service = new ServicePlayer();
            Console.WriteLine("Creating Service Player");
            AuthPlayerRequest authPlayerRequest = new AuthPlayerRequest();
            Console.WriteLine("Creating Auth Player");

            authPlayerRequest.Email = "renan.zanelato@gmail.com";
            authPlayerRequest.Password = "teste123";

            Console.WriteLine(authPlayerRequest);
            Console.WriteLine(authPlayerRequest.Email);
            Console.WriteLine(authPlayerRequest.Password);

            AddingPlayerRequest addingPlayerRequest = new AddingPlayerRequest();
            addingPlayerRequest.Email = authPlayerRequest.Email;
            addingPlayerRequest.Password = authPlayerRequest.Password;
            addingPlayerRequest.FirstName = "Renan";
            addingPlayerRequest.LastName = "Zanelato";

            AuthPlayerResponse authPlayerResponse = service.AuthPlayer(authPlayerRequest);

            AddingPlayerResponse addingPlayerResponse = service.AddingPlayer(addingPlayerRequest);

            Console.WriteLine("isValid ->" + service.IsValid());

            if (!service.IsValid())
            {
                service.Notifications.ToList().ForEach(x =>
                {
                    Console.WriteLine(x.Message);
                });
            }

            Console.ReadKey();
            */
        }
    }
}
