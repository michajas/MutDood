using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MutDood.Storage.Interfaces.Core;

namespace MutDood.Storage.Interfaces
{
    public interface IStorage
    {
        Oid Save(IStorable toStore);

    }
}
