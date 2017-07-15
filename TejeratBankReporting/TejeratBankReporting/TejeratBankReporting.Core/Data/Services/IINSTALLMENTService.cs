using System.Collections.Generic;

namespace TejeratBankReporting.Core
{
    
    public interface IInstallmentService
    {

        List<Installment> List();
    }
}