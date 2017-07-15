

namespace TejeratBankReporting.Core
{

    using System.Collections.Generic;
    public interface INacLogRepository : IRepository<NacLog, decimal>
    {
        List<NacLog> List();

    }
}
