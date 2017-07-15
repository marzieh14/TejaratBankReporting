namespace TejeratBankReporting.Core
{

    using System.Collections.Generic;
    public interface IInstallmentRepository : IRepository<Installment, int>
    {
        List<Installment> List();

    }
}