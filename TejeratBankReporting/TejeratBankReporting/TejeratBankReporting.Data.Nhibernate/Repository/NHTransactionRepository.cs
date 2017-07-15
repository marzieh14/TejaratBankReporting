

namespace LeatherMarket.Data.Nhibernate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TejeratBankReporting.Core;
    using TejeratBankReporting.Data.Nhibernate;
    public class NHTransactionRepository : NhRepositoryBase<Transaction, decimal>, ITransactionRepository
    {
        public void Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public Installment Get(decimal key)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> List()
        {
           // var hh1 = Db<Statement>().ToList();
            var hh= Db<Transaction>().ToList();
            return hh;
        }
    }

}