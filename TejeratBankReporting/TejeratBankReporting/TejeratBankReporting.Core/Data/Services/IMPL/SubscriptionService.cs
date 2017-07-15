namespace TejeratBankReporting.Core
{
    using System.Linq;
    using System;
    using System.Collections.Generic;
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository _iSubscriptionRepository;
        public SubscriptionService(ISubscriptionRepository iSubscriptionRepository)
        {
            _iSubscriptionRepository = iSubscriptionRepository;
        }
        [UnitOfWork]
        public List<Subscription> List()
        {
            var hh = _iSubscriptionRepository.GetAll().ToList();
            return hh;
        }

    }
}