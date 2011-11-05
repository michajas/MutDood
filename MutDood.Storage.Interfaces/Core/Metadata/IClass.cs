using System.Collections.Generic;
using MutDood.Storage.Interfaces.Core.Storage;

namespace MutDood.Storage.Interfaces.Core.Metadata
{
    public interface IClass
    {
        string TypeName { get; set; }
        IClass BaseType { get; set; }
        long MetadataId { get; set; }
        IEnumerable<IProperty> Properties { get; set; }
        IEnumerable<IMethod> Methods { get; set; }
    }
}