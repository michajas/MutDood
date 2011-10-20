using System;

namespace MutDood.Storage.Interfaces.Core.Storage
{
    public interface IProperty
    {
        Type Type { get; set; }
        Int64 MetadataId { get; set; }
        bool IsStorable();
    }
}