namespace TejeratBankReporting.Core
{
    using System.Linq;
    using System;
    using System.Collections.Generic;
    public class NacLogService : INacLogService
    {
        private readonly INacLogRepository _iNacLogRepository;
        public NacLogService(INacLogRepository iNacLogRepository)
        {
            _iNacLogRepository = iNacLogRepository;
        }
        [UnitOfWork]
        public List<NacLog> List()
        {
            var hh = _iNacLogRepository.GetAll().ToList();
            return hh;
        }

    }
}