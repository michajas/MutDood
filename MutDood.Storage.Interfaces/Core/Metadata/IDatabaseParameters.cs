using System;

namespace MutDood.Storage.Interfaces.Core.Metadata
{
    public interface IDatabaseParameters
    {
        string BaseDirectory { get; set; }
        string Name { get; set; }
        StorageStrategy Strategy { get; set; }
        Int64 StartupSize { get; set; }
        Int32 IncreaseFactor { get; set; }
    }
}