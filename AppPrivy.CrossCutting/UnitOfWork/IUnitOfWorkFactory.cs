using System;

namespace AppPrivy.CrossCutting.UnitOfWork
{
    public interface IUnitOfWorkFactory : IDisposable
    {
        IUnitOfWork Create();
    }
}
