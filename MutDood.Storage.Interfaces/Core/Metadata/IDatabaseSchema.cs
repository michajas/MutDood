using System.Collections.Generic;
using MutDood.Storage.Interfaces.Core.Storage;

namespace MutDood.Storage.Interfaces.Core.Metadata
{
    public interface IDatabaseSchema 
    {
        Did DatabaseId { get; set; }
        IEnumerable<IClass> Classes { get; set; }
    }
}