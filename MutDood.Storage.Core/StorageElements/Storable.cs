using System.Collections.Generic;
using MutDood.Storage.Interfaces.Core.Storage;

namespace MutDood.Storage.Core.StorageElements
{
    public class Storable : IStorable
    {
        public Oid Oid { get; set; }
        public Dictionary<IProperty, object> Properties { get; set; }
        public Dictionary<IMethod, string> Methods { get; set; }
    }
}