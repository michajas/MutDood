using MutDood.Storage.Interfaces.Core;
using MutDood.Storage.Interfaces.Core.Metadata;
using MutDood.Storage.Interfaces.Core.Storage;

namespace MutDood.Storage.Interfaces
{
    /// <summary>
    /// Facilitating methods for objects I/O 
    /// </summary>
    public interface IStorage
    {
        Oid Save(Did dbId, IStorable toStore);
        IStorable Get(Did dbId, Oid oid);
        IStorable[] Find(Did dbId, ISearchCriteria searchCriteria);
    }
}
