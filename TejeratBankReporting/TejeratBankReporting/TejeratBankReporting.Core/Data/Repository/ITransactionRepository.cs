namespace TejeratBankReporting.Core
{

    using System.Collections.Generic;
    public interface ITransactionRepository : IRepository<Transaction, decimal>
    {
        List<Transaction> List();

    }
}