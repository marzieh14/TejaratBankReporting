

namespace TejeratBankReporting.Core {
    
    public class TRANSACTION 
    {
        public TRANSACTION() { }
        public virtual decimal ID { get; set; }
        public virtual decimal ACCNO { get; set; }
        public virtual string ACTIVEDATE { get; set; }
        public virtual decimal AMOUNT { get; set; }
        public virtual decimal BALANCE { get; set; }
        public virtual string BILLTYPE { get; set; }
        public virtual string CARDNO { get; set; }
        public virtual string DESCRIPTION { get; set; }
        public virtual decimal FEEAMOUNT { get; set; }
        public virtual decimal FWIMD { get; set; }
        public virtual decimal ID1 { get; set; }
        public virtual decimal ID2 { get; set; }
        public virtual decimal IMD { get; set; }
        public virtual string REGDATE { get; set; }
        public virtual string REGTIME { get; set; }
        public virtual decimal RRN { get; set; }
        public virtual decimal STAN { get; set; }
        public virtual decimal STATE { get; set; }
        public virtual string TERMINALID { get; set; }
        public virtual string TERMINALTYPE { get; set; }
        public virtual string TRANSSIGN { get; set; }
        public virtual string TRANSTYPE { get; set; }
        public virtual decimal TRNDATE { get; set; }
    }
}
