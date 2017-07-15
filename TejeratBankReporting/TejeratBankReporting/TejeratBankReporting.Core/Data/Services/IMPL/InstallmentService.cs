namespace TejeratBankReporting.Core
{
    using System.Linq;
    using System;
    using System.Collections.Generic;
    public class InstallmentService : IInstallmentService
    {
        private readonly IInstallmentRepository _installmentRepository;
        public InstallmentService(IInstallmentRepository installmenRepository)
        {
            _installmentRepository = installmenRepository;
        }
        [UnitOfWork]
        public List<Installment> List()
        {
            var hh = _installmentRepository.GetAll().ToList();
            return hh;
        }

    }
}