



namespace TejeratBankReporting.Core
{
    using System;
    using System.Collections.Generic;
    public  class PagingModel<T> where T : class
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public List<T> MyList { get; set; }
        public int TotalPages { get; set; }

        //public PagingModel()
        //{
        //    PageSize = 20;
        //}
        public PagingModel(List<T> source, int pageIndex, int pageSize, int totalCount)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalCount;
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);
            if (pageIndex > TotalPages) pageIndex = TotalPages;
            if (source != null)
                MyList = source;
        }

    }
}
