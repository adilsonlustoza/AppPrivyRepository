using System;
using System.Transactions;

namespace AppPrivy.CrossCutting.UnitOfWork
{
    internal class TransactionScopeUnitOfWork : IUnitOfWork
    {
        private bool disposed = false;

        private readonly TransactionScope transactionScope;

        public TransactionScopeUnitOfWork(IsolationLevel isolationLevel)
        {
            this.transactionScope = new TransactionScope(
                    TransactionScopeOption.Required,
                    new TransactionOptions
                    {
                        IsolationLevel = isolationLevel,
                        Timeout = TransactionManager.MaximumTimeout
                    });
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    this.transactionScope.Dispose();
                }

                disposed = true;
            }
        }

        public void Commit()
        {
            this.transactionScope.Complete();
        }

        public void RollBack()
        {
            this.Dispose();
        }
    }
}

