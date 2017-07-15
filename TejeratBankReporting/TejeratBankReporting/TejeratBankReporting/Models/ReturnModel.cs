using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TejeratBankReporting.Web.Models
{
    public class ApiResult
    {
        public String ErrDesc; //error message for show to user
        public String ErrMsg; //error message for show in app log
        //public String ExpireDate; //expire date of this data
        public int StateCode; // 0:Success, -1:Error, -2:No Data to display
        public object Data; //method resut

    }
}