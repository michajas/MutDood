using System;
using System.Collections.Generic;
using MutDood.Storage.Interfaces.Core.Metadata;
using MutDood.Storage.Interfaces.Core.Storage;

namespace MutDood.Storage.Core.MetadataElements
{
    public class DatabaseSchema : IDatabaseSchema
    {
        
        public Dictionary<IProperty, object> Properties { get; set; }
        public Dictionary<IMethod, string> Methods { get; set; }

        public Did DatabaseId { get; set; }

        public IEnumerable<IClass> Classes { get; set; }
    }
}