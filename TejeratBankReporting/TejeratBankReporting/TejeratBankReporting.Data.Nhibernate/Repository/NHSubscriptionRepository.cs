

namespace LeatherMarket.Data.Nhibernate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TejeratBankReporting.Core;
    using TejeratBankReporting.Data.Nhibernate;
    public class NHSubscriptionRepository : NhRepositoryBase<Subscription, decimal>, ISubscriptionRepository
    {
        public void Delete(decimal id)
        {
            throw new NotImplementedException();
        }

        public Installment Get(decimal key)
        {
            throw new NotImplementedException();
        }

        public List<Subscription> List()
        {
           // var hh1 = Db<Statement>().ToList();
            var hh= Db<Subscription>().ToList();
            return hh;
        }
    }

}