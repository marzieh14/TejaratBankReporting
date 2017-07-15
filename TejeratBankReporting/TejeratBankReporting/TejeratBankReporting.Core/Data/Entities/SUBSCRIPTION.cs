

namespace TejeratBankReporting.Core {
    
    public class SUBSCRIPTION 
    {
        public SUBSCRIPTION() { }
        public virtual decimal ACCNO { get; set; }
        public virtual decimal PAYMENTNO { get; set; }
        public virtual decimal AMOUNT { get; set; }
        public virtual decimal PAYMENTDATE { get; set; }
        public virtual decimal PAYMENTDATEOLD { get; set; }
        public virtual decimal REQPAYDATE { get; set; }
        public virtual decimal SHOWREMAINPAYMENT { get; set; }
        public virtual decimal SHOWTOTALAMOUNT { get; set; }
        public virtual decimal TOTALAMOUNT { get; set; }
        public virtual decimal TOTALPAYMENTNO { get; set; }
    }
}
