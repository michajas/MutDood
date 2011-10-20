using MutDood.Storage.Interfaces.Core.Metadata;
using MutDood.Storage.Interfaces.Core.Storage;

namespace MutDood.Storage.Interfaces
{
    /// <summary>
    /// Facilitating methods for metadata manipulation
    /// </summary>
    public interface IMetadataStorage
    {
        Oid SaveSchema(IStorable schemaStorable);
        IStorable GetSchema(Oid schemaOid);
        IStorable GetSchemaForDatabase(Did databaseId);
    }
}
