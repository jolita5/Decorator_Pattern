using System;
using System.Collections.Generic;
using System.Threading;


namespace Decorator
{
    public class SomeSlowExpensiveThing : IGameLookupProvider
    {

        public IEnumerable<string> GetVideoGameList()
        {
            Console.WriteLine("Using the old slow way...");
            Thread.Sleep(3000);

            return  new List<string> {"Dig dug", "Prince of Persia", "Somthing else"};
        }
    }
}
