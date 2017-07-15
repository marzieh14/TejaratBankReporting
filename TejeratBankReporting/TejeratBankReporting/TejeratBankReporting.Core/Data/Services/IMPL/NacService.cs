namespace TejeratBankReporting.Core
{
    using System.Linq;
    using System;
    using System.Collections.Generic;
    public class NacService : INacService
    {
        private readonly INacRepository _iNacRepository;
        public NacService(INacRepository iNacRepository)
        {
            _iNacRepository = iNacRepository;
        }
        [UnitOfWork]
        public List<Nac> List()
        {
            var hh = _iNacRepository.GetAll().ToList();
            return hh;
        }

    }
}