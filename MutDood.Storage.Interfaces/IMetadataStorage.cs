using MutDood.Storage.Interfaces.Core.Metadata;
using MutDood.Storage.Interfaces.Core.Storage;

namespace MutDood.Storage.Interfaces
{
    /// <summary>
    /// Facilitating methods for metadata manipulation
    /// </summary>
    public interface IMetadataStorage
    {
        Oid SaveSchema(IDatabaseSchema schema);
        IDatabaseSchema GetSchema(Did databaseId);
        IDatabaseSchema GetSchemaForDatabase(Did databaseId);
    }
}
