using System;
using xGame.Domain.Interfaces.Services;
using xGame.Domain.Services;
using xGame.Domain.Arguments.Player;
namespace xGame.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            IServicePlayer service = new ServicePlayer();
            Console.WriteLine("Creating Service Player");
            AuthPlayerRequest request = new AuthPlayerRequest();
            Console.WriteLine("Creating Auth Player");

            request.Email = "renan.zanelato@gazin.com.br";
            request.Password = "teste";

            service.AuthPlayer(request);
            Console.ReadKey();
        }
    }
}
