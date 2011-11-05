using MutDood.Storage.Interfaces.Core.Metadata;

namespace MutDood.Storage.Core.MetadataElements
{
    public class DatabaseParameters : IDatabaseParameters
    {
        public string BaseDirectory { get; set; }
        public string Name { get; set; }
        public StorageStrategy Strategy { get; set; }
        public long StartupSize { get; set; }
        public int IncreaseFactor { get; set; }
    }
}