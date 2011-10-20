using MutDood.Storage.Interfaces.Core;
using MutDood.Storage.Interfaces.Core.Metadata;

namespace MutDood.Storage.Interfaces
{
    /// <summary>
    /// Facilitating methods for manipulating storage settings
    /// </summary>
    public interface IStorageManagement
    {
        Did CreateDatabase(IDatabaseParameters databaseParameters);
        DeleteDatabaseStatus RemoveDatabase(IDatabaseRemoveParameters databaseRemoveParameters);
        IDatabaseParameters[] GetDatabases();
        IDatabaseParameters GetDatabase(Did did);
    }
}