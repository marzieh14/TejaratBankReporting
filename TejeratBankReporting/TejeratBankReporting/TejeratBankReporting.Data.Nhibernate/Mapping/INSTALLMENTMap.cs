

namespace TejeratBankReporting.Data.Nhibernate {
    using FluentNHibernate.Mapping;
    using TejeratBankReporting.Core;

    public class INSTALLMENTMap : ClassMap<Installment> {
        
        public INSTALLMENTMap() {
            Table("INSTALLMENTS");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("IID");
            Map(x => x.CONTRACTID).Column("CONTRACTID").Not.Nullable();
            Map(x => x.NO).Column("NO").Not.Nullable();
            Map(x => x.BENEFIT).Column("BENEFIT").Not.Nullable();
            Map(x => x.BENEFITPAYDATE).Column("BENEFITPAYDATE").Not.Nullable();
            Map(x => x.CARDTYPE).Column("CARDTYPE").Not.Nullable();
            Map(x => x.DELAY).Column("DELAY").Not.Nullable();
            Map(x => x.DELAYEDDATE).Column("DELAYEDDATE").Not.Nullable();
            Map(x => x.FINEAMOUNT).Column("FINEAMOUNT").Not.Nullable();
            Map(x => x.FINEPAYDATE).Column("FINEPAYDATE").Not.Nullable();
            Map(x => x.FINESTATUS).Column("FINESTATUS").Not.Nullable();
            Map(x => x.IDm).Column("ID").Not.Nullable();
            Map(x => x.ISBEFORESETTLING).Column("ISBEFORESETTLING").Not.Nullable();
            Map(x => x.ISEXPORTED).Column("ISEXPORTED").Not.Nullable();
            Map(x => x.ISRECHARGED).Column("ISRECHARGED").Not.Nullable();
            Map(x => x.LASTFINECALCDATE).Column("LASTFINECALCDATE").Not.Nullable();
            Map(x => x.MATURITYDATE).Column("MATURITYDATE").Not.Nullable();
            Map(x => x.MELICODE).Column("MELICODE").Not.Nullable();
            Map(x => x.ORGPAYMENT).Column("ORGPAYMENT").Not.Nullable();
            Map(x => x.PAYAMOUNT).Column("PAYAMOUNT").Not.Nullable();
            Map(x => x.PAYDATE).Column("PAYDATE").Not.Nullable();
            Map(x => x.PAYDATEOLD).Column("PAYDATEOLD").Not.Nullable();
            Map(x => x.PAYMENTRECENT).Column("PAYMENTRECENT").Not.Nullable();
            Map(x => x.PAYMENTSTATUS).Column("PAYMENTSTATUS").Not.Nullable();
            Map(x => x.REMBENEFIT).Column("REMBENEFIT").Not.Nullable();
            Map(x => x.REMPAYMENT).Column("REMPAYMENT").Not.Nullable();
            Map(x => x.REQPAYDATE).Column("REQPAYDATE").Not.Nullable();
            Map(x => x.SENDPAYMENT).Column("SENDPAYMENT").Not.Nullable();
            Map(x => x.SENDPAYMENTDATE).Column("SENDPAYMENTDATE").Not.Nullable();
            Map(x => x.TOTALAMOUNT).Column("TOTALAMOUNT").Not.Nullable();
            Map(x => x.TOTALBENEFIT).Column("TOTALBENEFIT").Not.Nullable();
            Map(x => x.TOTALCOUNT).Column("TOTALCOUNT").Not.Nullable();
            Map(x => x.TOTALPAYMENT).Column("TOTALPAYMENT").Not.Nullable();
        }
    }
}
