using System;
using MutDood.Storage.Core.Serialization;
using MutDood.Storage.Interfaces;
using MutDood.Storage.Interfaces.Core;
using MutDood.Storage.Interfaces.Core.Metadata;
using MutDood.Storage.Interfaces.Core.Storage;
using MutDood.Storage.Interfaces.Strategy;
using MutDood.Storage.Strategies.Speed;

namespace MutDood.Storage.Core
{
    public class Storage : IStorage, IMetadataStorage
    {
        private IEngine _engine;
        private readonly ISerializer _serializer;

        private Storage(IEngine engine, ISerializer serializer)
        {
            _engine = engine;
            _serializer = serializer;
        }

        public static IStorage Create(StorageStrategy storageStrategy)
        {
            IEngine engine = null;
            switch (storageStrategy)
            {
                case StorageStrategy.Speed:
                    engine = Engine.Create();
                    break;
                case StorageStrategy.SpeedEsent:
                    break;
                default:
                    break;
            }
            return new Storage(engine, DefaultSerializer.Create());

        }

        public Oid Save(Did dbId, IStorable toStore)
        {
            var serialized = _serializer.Serialize(toStore);

            return new Oid(new byte[] {0x01}, new byte[] {0x02});
        }

        public IStorable Get(Did dbId, Oid oid)
        {
            throw new NotImplementedException();
        }

        public IStorable[] Find(Did dbId, ISearchCriteria searchCriteria)
        {
            throw new NotImplementedException();
        }


        public Oid SaveSchema(IDatabaseSchema schema)
        {
            throw new NotImplementedException();
        }

        public IDatabaseSchema GetSchema(Did databaseId)
        {
            throw new NotImplementedException();
        }

        public IDatabaseSchema GetSchemaForDatabase(Did databaseId)
        {
            throw new NotImplementedException();
        }
    }
}