using System;
using SimpleTrader.EntityFrameWork.Services;
using SimpleTrader.Models;
using SimpleTrader.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> userService = new GenericDataService<User>(new SimpleTrader.EntityFrameWork.SimpleTraderDbContextFactory());
            userService.Create(new User { Username = "Test" }).Wait();
        }
    }
}
