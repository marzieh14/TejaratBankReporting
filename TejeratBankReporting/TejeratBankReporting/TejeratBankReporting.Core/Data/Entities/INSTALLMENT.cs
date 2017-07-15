
namespace TejeratBankReporting.Core {
    
    public class Installment: Entity<int> {
        public Installment() { }
        public virtual decimal CONTRACTID { get; set; }
        public virtual decimal NO { get; set; }
        public virtual decimal BENEFIT { get; set; }
        public virtual decimal BENEFITPAYDATE { get; set; }
        public virtual decimal CARDTYPE { get; set; }
        public virtual decimal DELAY { get; set; }
        public virtual decimal DELAYEDDATE { get; set; }
        public virtual decimal FINEAMOUNT { get; set; }
        public virtual decimal FINEPAYDATE { get; set; }
        public virtual decimal FINESTATUS { get; set; }
        public virtual decimal IDm { get; set; }
        public virtual decimal ISBEFORESETTLING { get; set; }
        public virtual decimal ISEXPORTED { get; set; }
        public virtual decimal ISRECHARGED { get; set; }
        public virtual decimal LASTFINECALCDATE { get; set; }
        public virtual decimal MATURITYDATE { get; set; }
        public virtual decimal MELICODE { get; set; }
        public virtual decimal ORGPAYMENT { get; set; }
        public virtual decimal PAYAMOUNT { get; set; }
        public virtual decimal PAYDATE { get; set; }
        public virtual decimal PAYDATEOLD { get; set; }
        public virtual double PAYMENTRECENT { get; set; }
        public virtual decimal PAYMENTSTATUS { get; set; }
        public virtual decimal REMBENEFIT { get; set; }
        public virtual decimal REMPAYMENT { get; set; }
        public virtual decimal REQPAYDATE { get; set; }
        public virtual decimal SENDPAYMENT { get; set; }
        public virtual decimal SENDPAYMENTDATE { get; set; }
        public virtual decimal TOTALAMOUNT { get; set; }
        public virtual decimal TOTALBENEFIT { get; set; }
        public virtual decimal TOTALCOUNT { get; set; }
        public virtual decimal TOTALPAYMENT { get; set; }
    }
}
