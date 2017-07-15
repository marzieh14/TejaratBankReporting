

namespace LeatherMarket.Data.Nhibernate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TejeratBankReporting.Core;
    using TejeratBankReporting.Data.Nhibernate;
    public class NHNacLogRepository : NhRepositoryBase<NacLog, decimal>, INacLogRepository
    {
        public List<NacLog> List()
        {
            return Db<NacLog>().ToList();
        }
    }

}