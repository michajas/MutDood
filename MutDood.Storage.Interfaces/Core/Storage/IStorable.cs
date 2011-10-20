using System.Collections.Generic;

namespace MutDood.Storage.Interfaces.Core.Storage
{
    public interface IStorable
    {
        Oid Oid { get; set; }
        Dictionary<IProperty, object> Properties { get; set; }
        Dictionary<IMethod, string> Methods { get; set; }
    }
}
