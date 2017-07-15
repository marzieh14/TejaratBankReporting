using System.Collections.Generic;

namespace TejeratBankReporting.Core
{
    
    public interface ITransactionService
    {

        List<Transaction> List();
    }
}