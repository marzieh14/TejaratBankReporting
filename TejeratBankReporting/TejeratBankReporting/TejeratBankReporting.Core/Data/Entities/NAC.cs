

namespace TejeratBankReporting.Core {
    
    public class NAC 
    {
        public NAC() { }
        public virtual decimal CARDTYPE { get; set; }
        public virtual string MELICODE { get; set; }
        public virtual decimal ACCDATE { get; set; }
        public virtual decimal ACCNO { get; set; }
        public virtual decimal ACTIVESTATUS { get; set; }
        public virtual decimal AMACCNO { get; set; }
        public virtual decimal BALANCE { get; set; }
        public virtual string BDATE { get; set; }
        public virtual decimal BLOCKAMOUNT { get; set; }
        public virtual decimal CALCSUBSCRIPTION { get; set; }
        public virtual string CARDNO { get; set; }
        public virtual decimal CARDSEQUNCE { get; set; }
        public virtual decimal CIF { get; set; }
        public virtual decimal EMAILACTIVE { get; set; }
        public virtual string EMAILADD { get; set; }
        public virtual decimal EXPDATE { get; set; }
        public virtual string FAMILY { get; set; }
        public virtual decimal LASTSTATEMENTDATE { get; set; }
        public virtual decimal LASTSTPERIOD { get; set; }
        public virtual decimal LASTTRANSDATE { get; set; }
        public virtual decimal LOGID { get; set; }
        public virtual decimal MACNA { get; set; }
        public virtual decimal MACNA_ESTELAMID { get; set; }
        public virtual decimal MACNA_ETEBARID { get; set; }
        public virtual string MOBILENO { get; set; }
        public virtual string NAME { get; set; }
        public virtual decimal NEED_REGENERATE_STATMENT { get; set; }
        public virtual decimal PAPACCNO { get; set; }
        public virtual string PAPBRANCH { get; set; }
        public virtual decimal REGBRANCHCODE { get; set; }
        public virtual string REGDATETIME { get; set; }
        public virtual decimal REQTOPCREDIT { get; set; }
        public virtual decimal SELECTED_PAYMENT_TYPE { get; set; }
        public virtual decimal SEX { get; set; }
        public virtual decimal SMSACTIVE { get; set; }
        public virtual string STATEMENTDAY { get; set; }
        public virtual decimal STATUS { get; set; }
        public virtual System.Nullable<decimal> TACCNO { get; set; }
        public virtual string TELCODE { get; set; }
        public virtual System.Nullable<decimal> TELNO { get; set; }
        public virtual System.Nullable<decimal> UNUSED_PAY_STATUS { get; set; }
        public virtual System.Nullable<decimal> UNUSED_PAYDATE { get; set; }
        public virtual System.Nullable<decimal> UNUSEDFEE { get; set; }
    }
}
