using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's begin!");

            var myGameService = new GameNameServie((new FastCachedGameThing(new SomeSlowExpensiveThing())));

            var list = myGameService.GetGameList();
            _displayGames(list);

            list = myGameService.GetGameList();
            _displayGames(list);

            list = myGameService.GetGameList();
            _displayGames(list);

            Console.WriteLine("Well done!");


            Console.ReadLine();
        }

        private static void _displayGames(IEnumerable<string> gameList)
        {
            foreach (var game in gameList)
            {
                Console.WriteLine(game);
            }
        }
    }
}
