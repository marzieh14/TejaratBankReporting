

namespace TejeratBankReporting.Data.Nhibernate {
    using FluentNHibernate.Mapping;
    using TejeratBankReporting.Core;

    public class NACLOGMap : ClassMap<NacLog> {
        
        public NACLOGMap() {
			Table("NACLOG");
			LazyLoad();
            Id(x => x.Id).GeneratedBy.Assigned().Column("ACCNO");
			Map(x => x.ADDRESS).Column("ADDRESS").Not.Nullable().Length(200);
			Map(x => x.BDATE).Column("BDATE").Not.Nullable().Length(6);
			Map(x => x.BPLACECODE).Column("BPLACECODE").Not.Nullable();
			Map(x => x.BSODOORCODE).Column("BSODOORCODE").Not.Nullable();
			Map(x => x.CARDNO).Column("CARDNO").Not.Nullable().Length(16);
			Map(x => x.CARDTYPE).Column("CARDTYPE").Not.Nullable();
			Map(x => x.CIF).Column("CIF").Not.Nullable();
			Map(x => x.EMAILADD).Column("EMAILADD").Not.Nullable().Length(50);
			Map(x => x.FAMILY).Column("FAMILY").Not.Nullable().Length(50);
			Map(x => x.FATHERNAME).Column("FATHERNAME").Not.Nullable().Length(50);
			Map(x => x.ID).Column("ID").Not.Nullable();
			Map(x => x.LASTSTATE).Column("LASTSTATE").Not.Nullable();
			Map(x => x.LIVECITYCODE).Column("LIVECITYCODE").Not.Nullable();
			Map(x => x.LIVESTATECODE).Column("LIVESTATECODE").Not.Nullable();
			Map(x => x.MAINSTREET).Column("MAINSTREET").Not.Nullable().Length(50);
			Map(x => x.MELICODE).Column("MELICODE").Not.Nullable().Length(10);
			Map(x => x.MOBILENO).Column("MOBILENO").Not.Nullable();
			Map(x => x.NAME).Column("NAME").Not.Nullable().Length(30);
			Map(x => x.PAPACCNO).Column("PAPACCNO").Not.Nullable();
			Map(x => x.POPBRANCH).Column("POPBRANCH").Not.Nullable().Length(5);
			Map(x => x.POSTALCODE).Column("POSTALCODE").Not.Nullable().Length(10);
			Map(x => x.REGBRANCHCODE).Column("REGBRANCHCODE").Not.Nullable();
			Map(x => x.REGDATETIME).Column("REGDATETIME").Not.Nullable().Length(17);
			Map(x => x.REGIP).Column("REGIP").Not.Nullable().Length(15);
			Map(x => x.REGUSER).Column("REGUSER").Not.Nullable().Length(11);
			Map(x => x.REQTOPCREDIT).Column("REQTOPCREDIT").Not.Nullable();
			Map(x => x.SELECTED_PAYMENT_TYPE).Column("SELECTED_PAYMENT_TYPE").Not.Nullable();
			Map(x => x.SEX).Column("SEX").Not.Nullable();
			Map(x => x.SHID).Column("SHID").Not.Nullable().Length(10);
			Map(x => x.SHSERI1).Column("SHSERI1").Not.Nullable().Length(10);
			Map(x => x.SHSERI2).Column("SHSERI2").Not.Nullable().Length(9);
			Map(x => x.SHSERIAL).Column("SHSERIAL").Not.Nullable().Length(10);
			Map(x => x.TELCODE).Column("TELCODE").Not.Nullable().Length(5);
			Map(x => x.TELNO).Column("TELNO").Not.Nullable();
        }
    }
}
