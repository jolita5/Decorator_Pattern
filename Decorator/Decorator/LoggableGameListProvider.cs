using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class LoggableGameListProvider : IGameLookupProvider
    {
        private readonly IGameLookupProvider _innerGameLookupProvider;

        public LoggableGameListProvider(IGameLookupProvider innerGameLookupProvider)
        {
            _innerGameLookupProvider = innerGameLookupProvider;
        }

        public IEnumerable<string> GetVideoGameList()
        {
            Console.WriteLine("Logging it...");
            var list = _innerGameLookupProvider.GetVideoGameList();

            Console.WriteLine(string.Join(",", list));

            return list;
        }
    }
}
