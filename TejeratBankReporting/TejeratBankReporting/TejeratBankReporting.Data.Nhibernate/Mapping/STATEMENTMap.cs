

namespace TejeratBankReporting.Data.Nhibernate {
    using FluentNHibernate.Mapping;
    using TejeratBankReporting.Core;

    public class STATEMENTMap : ClassMap<Statement> {
        
        public STATEMENTMap() {
			Table("STATEMENTS");
			LazyLoad();
			CompositeId();
			Map(x => x.ACCNO).Column("ACCNO").Not.Nullable();
			Map(x => x.PERIOD).Column("PERIOD").Not.Nullable();
			Map(x => x.BUYAMOUNT).Column("BUYAMOUNT").Not.Nullable();
			Map(x => x.CARDTYPE).Column("CARDTYPE").Not.Nullable();
			Map(x => x.CREATEHTMLFILE).Column("CREATEHTMLFILE").Not.Nullable();
			Map(x => x.DELAY).Column("DELAY").Not.Nullable();
			Map(x => x.DELAYEDDATE).Column("DELAYEDDATE").Not.Nullable();
			Map(x => x.ENDDATE).Column("ENDDATE").Not.Nullable();
			Map(x => x.FEE).Column("FEE").Not.Nullable();
			Map(x => x.FEEPAYDATE).Column("FEEPAYDATE").Not.Nullable();
			Map(x => x.FEEPAYDATEOLD).Column("FEEPAYDATEOLD").Not.Nullable();
			Map(x => x.FEESTATUS).Column("FEESTATUS").Not.Nullable();
			Map(x => x.FINEAMOUNT).Column("FINEAMOUNT").Not.Nullable();
			Map(x => x.FINEPAYDATE).Column("FINEPAYDATE").Not.Nullable();
			Map(x => x.FINESTATUS).Column("FINESTATUS").Not.Nullable();
			Map(x => x.ID).Column("ID").Not.Nullable();
			Map(x => x.ISEXPORTED).Column("ISEXPORTED").Not.Nullable();
			Map(x => x.LASTFINECALCDATE).Column("LASTFINECALCDATE").Not.Nullable();
			Map(x => x.MATURITYDATE).Column("MATURITYDATE").Not.Nullable();
			Map(x => x.MELICODE).Column("MELICODE").Not.Nullable();
			Map(x => x.PAYAMOUNT).Column("PAYAMOUNT").Not.Nullable();
			Map(x => x.PAYCOUNT).Column("PAYCOUNT").Not.Nullable();
			Map(x => x.PAYDATE).Column("PAYDATE").Not.Nullable();
			Map(x => x.PAYMENT1).Column("PAYMENT1").Not.Nullable();
			Map(x => x.PAYMENT2).Column("PAYMENT2").Not.Nullable();
			Map(x => x.PAYMENTMCOUNT1).Column("PAYMENTMCOUNT1").Not.Nullable();
			Map(x => x.PAYMENTMCOUNT2).Column("PAYMENTMCOUNT2").Not.Nullable();
			Map(x => x.PAYMENTPERCENT).Column("PAYMENTPERCENT").Not.Nullable();
			Map(x => x.PAYMENTTYPE).Column("PAYMENTTYPE").Not.Nullable();
			Map(x => x.PAYSTATUS).Column("PAYSTATUS").Not.Nullable();
			Map(x => x.REQPAYDATE).Column("REQPAYDATE").Not.Nullable();
			Map(x => x.SELECTED_PAYMENT_TYPE).Column("SELECTED_PAYMENT_TYPE").Not.Nullable();
			Map(x => x.SENDMAIL).Column("SENDMAIL").Not.Nullable();
			Map(x => x.SENDPAYMENT).Column("SENDPAYMENT").Not.Nullable();
			Map(x => x.SENDPAYMENTDATE).Column("SENDPAYMENTDATE").Not.Nullable();
			Map(x => x.SENDSMS).Column("SENDSMS").Not.Nullable();
			Map(x => x.SENDTOCFSDATE).Column("SENDTOCFSDATE").Not.Nullable();
			Map(x => x.SENDTOSGBDATE).Column("SENDTOSGBDATE").Not.Nullable();
			Map(x => x.STARTDATE).Column("STARTDATE").Not.Nullable();
			Map(x => x.SUBSCRIPTIONAMOUNT).Column("SUBSCRIPTIONAMOUNT").Not.Nullable();
			Map(x => x.TOTALFEEAMOUNT).Column("TOTALFEEAMOUNT").Not.Nullable();
			Map(x => x.TOTALPAYAMOUNT1).Column("TOTALPAYAMOUNT1").Not.Nullable();
			Map(x => x.TOTALPAYAMOUNT2).Column("TOTALPAYAMOUNT2").Not.Nullable();
			Map(x => x.TOTALPAYAMOUNT3).Column("TOTALPAYAMOUNT3").Not.Nullable();
        }
    }
}
