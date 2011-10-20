using System;

namespace MutDood.Storage.Interfaces.Core.Storage
{
    public interface IMethod
    {
        Type ReturnType { get; set; }
        Type[] ParametersTypes { get; set; }

    }
}