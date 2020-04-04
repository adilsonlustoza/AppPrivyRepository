using System;

namespace AppPrivy.CrossCutting.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {

        void Commit();

        void RollBack();

    }
}
