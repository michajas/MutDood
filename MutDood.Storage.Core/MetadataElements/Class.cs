using System.Collections.Generic;
using MutDood.Storage.Interfaces.Core.Metadata;
using MutDood.Storage.Interfaces.Core.Storage;

namespace MutDood.Storage.Core.MetadataElements
{
    public class Class : IClass
    {
        public string TypeName { get; set; }
        public IClass BaseType { get; set; }
        public long MetadataId { get; set; }
        public IEnumerable<IProperty> Properties { get; set; }
        public IEnumerable<IMethod> Methods { get; set; }
    }
}