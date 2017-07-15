
namespace TejeratBankReporting.Data.Nhibernate {

    using FluentNHibernate.Mapping;
    using TejeratBankReporting.Core;
    public class SUBSCRIPTIONMap : ClassMap<Subscription> {
        
        public SUBSCRIPTIONMap() {
			Table("SUBSCRIPTION");
			LazyLoad();
			CompositeId().KeyProperty(x => x.Id, "ACCNO").KeyProperty(x => x.PAYMENTNO, "PAYMENTNO");
			Map(x => x.AMOUNT).Column("AMOUNT").Not.Nullable();
			Map(x => x.PAYMENTDATE).Column("PAYMENTDATE").Not.Nullable();
			Map(x => x.PAYMENTDATEOLD).Column("PAYMENTDATEOLD").Not.Nullable();
			Map(x => x.REQPAYDATE).Column("REQPAYDATE").Not.Nullable();
			Map(x => x.SHOWREMAINPAYMENT).Column("SHOWREMAINPAYMENT").Not.Nullable();
			Map(x => x.SHOWTOTALAMOUNT).Column("SHOWTOTALAMOUNT").Not.Nullable();
			Map(x => x.TOTALAMOUNT).Column("TOTALAMOUNT").Not.Nullable();
			Map(x => x.TOTALPAYMENTNO).Column("TOTALPAYMENTNO").Not.Nullable();
        }
    }
}
