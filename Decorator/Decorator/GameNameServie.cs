using System.Collections.Generic;


namespace Decorator
{
    public class GameNameServie
    {
        private readonly IGameLookupProvider _lookupProvider;

        public GameNameServie(IGameLookupProvider lookupProvider)
        {
            _lookupProvider = lookupProvider;
        }

        public IEnumerable<string> GetGameList()
        {
            return _lookupProvider.GetVideoGameList();
        }
    }
}
