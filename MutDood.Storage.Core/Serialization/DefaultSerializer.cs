using System;
using System.Collections.Generic;
using MutDood.Storage.Interfaces.Core;
using MutDood.Storage.Interfaces.Core.Storage;

namespace MutDood.Storage.Core.Serialization
{
    public class DefaultSerializer : ISerializer
    {
        private DefaultSerializer()
        {
            
        }
        public static ISerializer Create()
        {
            return new DefaultSerializer();
        }

        public List<ISerializedStorable> Serialize(IStorable objectToStore)
        {
            throw new NotImplementedException();
        }

        public IStorable Deserialize(ISerializedStorable serializedStorable)
        {
            throw new NotImplementedException();
        }
    }
}