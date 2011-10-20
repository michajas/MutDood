using MutDood.Storage.Interfaces.Core;
using MutDood.Storage.Interfaces.Core.Storage;

namespace MutDood.Storage.Interfaces
{
    /// <summary>
    /// Facilitating methods for objects I/O 
    /// </summary>
    public interface IStorage
    {
        Oid Save(IStorable toStore);
        IStorable Get(Oid oid);
        IStorable[] Find(ISearchCriteria searchCriteria);
    }
}
