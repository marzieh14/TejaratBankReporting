namespace TejeratBankReporting.Core
{

    using System.Collections.Generic;
    public interface IInstallmentRepository : IRepository<Installment, decimal>
    {
        List<Installment> List();

    }
}