using System;
using MutDood.Storage.Interfaces.Core.Storage;

namespace MutDood.Storage.Core.StorageElements
{
    public class Property : IProperty
    {
        public Type Type { get; set; }
        public long MetadataId { get; set; }
        public bool IsStorable()
        {
            return Type is IStorable;
        }
    }
}