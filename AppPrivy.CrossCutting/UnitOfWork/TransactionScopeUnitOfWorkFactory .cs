
using System.Transactions;

namespace AppPrivy.CrossCutting.UnitOfWork
{
    public class TransactionScopeUnitOfWorkFactory : IUnitOfWorkFactory
    {

        private readonly IsolationLevel _isolationLevel;
        private TransactionScopeUnitOfWork _transactionScopeUnitOfWork { get; set; }

        public TransactionScopeUnitOfWorkFactory(IsolationLevel isolationLevel)
        {
            _isolationLevel = isolationLevel;
        }
        public IUnitOfWork Create()
        {
            return _transactionScopeUnitOfWork = new TransactionScopeUnitOfWork(_isolationLevel);
        }

        public void Dispose()
        {
            _transactionScopeUnitOfWork.Dispose();
        }
    }
}
