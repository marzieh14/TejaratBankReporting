namespace TejeratBankReporting.Core
{

    using System.Collections.Generic;
    public interface INacRepository : IRepository<Nac, decimal>
    {
        List<Nac> List();

    }
}