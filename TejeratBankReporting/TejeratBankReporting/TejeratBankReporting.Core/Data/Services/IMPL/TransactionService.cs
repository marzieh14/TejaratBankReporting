namespace TejeratBankReporting.Core
{
    using System.Linq;
    using System;
    using System.Collections.Generic;
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _iTransactionRepository;
        public TransactionService(ITransactionRepository iTransactionRepository)
        {
            _iTransactionRepository = iTransactionRepository;
        }
        [UnitOfWork]
        public List<Transaction> List()
        {
            var hh = _iTransactionRepository.GetAll().ToList();
            return hh;
        }

    }
}