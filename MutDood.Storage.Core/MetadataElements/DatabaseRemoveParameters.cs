using System;
using MutDood.Storage.Interfaces.Core.Metadata;

namespace MutDood.Storage.Core.MetadataElements
{
    public class DatabaseRemoveParameters : IDatabaseRemoveParameters
    {
        public Did DatabaseToRemove { get; set; }
    }
}