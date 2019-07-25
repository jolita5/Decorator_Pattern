using System;
using System.Collections.Generic;


namespace Decorator
{
    public class FastCachedGameThing :IGameLookupProvider
    {
        private readonly IGameLookupProvider _innerGameLookupProvider;
        private IEnumerable<string> _cashedList;
        public FastCachedGameThing(IGameLookupProvider innerGameLookupProvider)
        {
            _innerGameLookupProvider = innerGameLookupProvider;
        }

        public IEnumerable<string> GetVideoGameList()
        {
            Console.WriteLine("New way in progress!");

            if (_cashedList == null)
            {
                _cashedList = _innerGameLookupProvider.GetVideoGameList();
            }
            return _cashedList;
        }
    }
}
