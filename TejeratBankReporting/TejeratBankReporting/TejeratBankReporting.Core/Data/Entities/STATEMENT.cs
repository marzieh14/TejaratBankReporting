

namespace TejeratBankReporting.Core {
    
    public class Statement {
        public Statement() { }
        public virtual decimal ACCNO { get; set; }
        public virtual decimal PERIOD { get; set; }
        public virtual decimal BUYAMOUNT { get; set; }
        public virtual decimal CARDTYPE { get; set; }
        public virtual decimal CREATEHTMLFILE { get; set; }
        public virtual decimal DELAY { get; set; }
        public virtual decimal DELAYEDDATE { get; set; }
        public virtual decimal ENDDATE { get; set; }
        public virtual decimal FEE { get; set; }
        public virtual decimal FEEPAYDATE { get; set; }
        public virtual decimal FEEPAYDATEOLD { get; set; }
        public virtual decimal FEESTATUS { get; set; }
        public virtual decimal FINEAMOUNT { get; set; }
        public virtual decimal FINEPAYDATE { get; set; }
        public virtual decimal FINESTATUS { get; set; }
        public virtual decimal ID { get; set; }
        public virtual decimal ISEXPORTED { get; set; }
        public virtual decimal LASTFINECALCDATE { get; set; }
        public virtual decimal MATURITYDATE { get; set; }
        public virtual decimal MELICODE { get; set; }
        public virtual decimal PAYAMOUNT { get; set; }
        public virtual decimal PAYCOUNT { get; set; }
        public virtual decimal PAYDATE { get; set; }
        public virtual decimal PAYMENT1 { get; set; }
        public virtual decimal PAYMENT2 { get; set; }
        public virtual decimal PAYMENTMCOUNT1 { get; set; }
        public virtual decimal PAYMENTMCOUNT2 { get; set; }
        public virtual double PAYMENTPERCENT { get; set; }
        public virtual decimal PAYMENTTYPE { get; set; }
        public virtual decimal PAYSTATUS { get; set; }
        public virtual decimal REQPAYDATE { get; set; }
        public virtual decimal SELECTED_PAYMENT_TYPE { get; set; }
        public virtual decimal SENDMAIL { get; set; }
        public virtual decimal SENDPAYMENT { get; set; }
        public virtual decimal SENDPAYMENTDATE { get; set; }
        public virtual decimal SENDSMS { get; set; }
        public virtual System.DateTime SENDTOCFSDATE { get; set; }
        public virtual System.DateTime SENDTOSGBDATE { get; set; }
        public virtual decimal STARTDATE { get; set; }
        public virtual decimal SUBSCRIPTIONAMOUNT { get; set; }
        public virtual decimal TOTALFEEAMOUNT { get; set; }
        public virtual decimal TOTALPAYAMOUNT1 { get; set; }
        public virtual decimal TOTALPAYAMOUNT2 { get; set; }
        public virtual decimal TOTALPAYAMOUNT3 { get; set; }
    }
}
