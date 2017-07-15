

namespace TejeratBankReporting.Core {
    
    public class Subscription : Entity<decimal>
    {
        public Subscription() { }
        public virtual decimal PAYMENTNO { get; set; }
        public virtual decimal AMOUNT { get; set; }
        public virtual decimal PAYMENTDATE { get; set; }
        public virtual decimal PAYMENTDATEOLD { get; set; }
        public virtual decimal REQPAYDATE { get; set; }
        public virtual decimal SHOWREMAINPAYMENT { get; set; }
        public virtual decimal SHOWTOTALAMOUNT { get; set; }
        public virtual decimal TOTALAMOUNT { get; set; }
        public virtual decimal TOTALPAYMENTNO { get; set; }
        public override bool Equals(object obj)
        {
            var other = obj as Subscription;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return this.Id == other.Id &&
                this.PAYMENTNO == other.PAYMENTNO;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash = (hash * 31) ^ Id.GetHashCode();
                hash = (hash * 31) ^ PAYMENTNO.GetHashCode();

                return hash;
            }
        }
    }
}
