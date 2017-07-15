

namespace TejeratBankReporting.Data.Nhibernate {
    using FluentNHibernate.Mapping;
    using TejeratBankReporting.Core;

    public class NACMap : ClassMap<NAC> {
        
        public NACMap() {
			Table("NAC");
			LazyLoad();
			CompositeId().KeyProperty(x => x.CARDTYPE, "CARDTYPE").KeyProperty(x => x.MELICODE, "MELICODE");
			Map(x => x.ACCDATE).Column("ACCDATE").Not.Nullable();
			Map(x => x.ACCNO).Column("ACCNO").Not.Nullable();
			Map(x => x.ACTIVESTATUS).Column("ACTIVESTATUS").Not.Nullable();
			Map(x => x.AMACCNO).Column("AMACCNO").Not.Nullable();
			Map(x => x.BALANCE).Column("BALANCE").Not.Nullable();
			Map(x => x.BDATE).Column("BDATE").Not.Nullable().Length(6);
			Map(x => x.BLOCKAMOUNT).Column("BLOCKAMOUNT").Not.Nullable();
			Map(x => x.CALCSUBSCRIPTION).Column("CALCSUBSCRIPTION").Not.Nullable();
			Map(x => x.CARDNO).Column("CARDNO").Not.Nullable().Length(16);
			Map(x => x.CARDSEQUNCE).Column("CARDSEQUNCE").Not.Nullable();
			Map(x => x.CIF).Column("CIF").Not.Nullable();
			Map(x => x.EMAILACTIVE).Column("EMAILACTIVE").Not.Nullable();
			Map(x => x.EMAILADD).Column("EMAILADD").Not.Nullable().Length(50);
			Map(x => x.EXPDATE).Column("EXPDATE").Not.Nullable();
			Map(x => x.FAMILY).Column("FAMILY").Not.Nullable().Length(100);
			Map(x => x.LASTSTATEMENTDATE).Column("LASTSTATEMENTDATE").Not.Nullable();
			Map(x => x.LASTSTPERIOD).Column("LASTSTPERIOD").Not.Nullable();
			Map(x => x.LASTTRANSDATE).Column("LASTTRANSDATE").Not.Nullable();
			Map(x => x.LOGID).Column("LOGID").Not.Nullable();
			Map(x => x.MACNA).Column("MACNA").Not.Nullable();
			Map(x => x.MACNA_ESTELAMID).Column("MACNA_ESTELAMID").Not.Nullable();
			Map(x => x.MACNA_ETEBARID).Column("MACNA_ETEBARID").Not.Nullable();
			Map(x => x.MOBILENO).Column("MOBILENO").Not.Nullable().Length(10);
			Map(x => x.NAME).Column("NAME").Not.Nullable().Length(50);
			Map(x => x.NEED_REGENERATE_STATMENT).Column("NEED_REGENERATE_STATMENT").Not.Nullable();
			Map(x => x.PAPACCNO).Column("PAPACCNO").Not.Nullable();
			Map(x => x.PAPBRANCH).Column("PAPBRANCH").Not.Nullable().Length(5);
			Map(x => x.REGBRANCHCODE).Column("REGBRANCHCODE").Not.Nullable();
			Map(x => x.REGDATETIME).Column("REGDATETIME").Not.Nullable().Length(17);
			Map(x => x.REQTOPCREDIT).Column("REQTOPCREDIT").Not.Nullable();
			Map(x => x.SELECTED_PAYMENT_TYPE).Column("SELECTED_PAYMENT_TYPE").Not.Nullable();
			Map(x => x.SEX).Column("SEX").Not.Nullable();
			Map(x => x.SMSACTIVE).Column("SMSACTIVE").Not.Nullable();
			Map(x => x.STATEMENTDAY).Column("STATEMENTDAY").Not.Nullable().Length(2);
			Map(x => x.STATUS).Column("STATUS").Not.Nullable();
			Map(x => x.TACCNO).Column("TACCNO");
			Map(x => x.TELCODE).Column("TELCODE").Length(5);
			Map(x => x.TELNO).Column("TELNO");
			Map(x => x.UNUSED_PAY_STATUS).Column("UNUSED_PAY_STATUS");
			Map(x => x.UNUSED_PAYDATE).Column("UNUSED_PAYDATE");
			Map(x => x.UNUSEDFEE).Column("UNUSEDFEE");
        }
    }
}
