namespace TejeratBankReporting.Core
{

    using System.Collections.Generic;
    public interface ISubscriptionRepository : IRepository<Subscription, decimal>
    {
        List<Subscription> List();

    }
}