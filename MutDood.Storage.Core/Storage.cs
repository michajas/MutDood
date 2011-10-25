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
    public class Storage : IStorage
    {
        private IEngine _engine;
        private ISerializer _serializer;

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

        public Oid Save(IStorable toStore)
        {
            throw new NotImplementedException();
        }

        public IStorable Get(Oid oid)
        {
            throw new NotImplementedException();
        }

        public IStorable[] Find(ISearchCriteria searchCriteria)
        {
            throw new NotImplementedException();
        }
    }
}