
using System.Collections.Generic;


namespace Decorator
{
    public interface IGameLookupProvider
    {
        IEnumerable<string> GetVideoGameList();
    }
}
