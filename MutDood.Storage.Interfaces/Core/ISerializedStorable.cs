using MutDood.Storage.Interfaces.Core.Storage;

namespace MutDood.Storage.Interfaces.Core
{
    public interface ISerializedStorable
    {
        byte[] Data { get; set; }
        Oid Oid { get; set; }
    }
}