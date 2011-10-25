using System.Collections.Generic;
using MutDood.Storage.Interfaces.Core.Storage;

namespace MutDood.Storage.Interfaces.Core
{
    public interface ISerializer
    {
        List<ISerializedStorable> Serialize(IStorable objectToStore);
        IStorable Deserialize(ISerializedStorable serializedStorable);
    }
}