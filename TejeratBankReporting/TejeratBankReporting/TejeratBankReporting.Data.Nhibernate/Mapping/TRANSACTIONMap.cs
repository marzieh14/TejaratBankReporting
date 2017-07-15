

namespace TejeratBankReporting.Data.Nhibernate {

    using FluentNHibernate.Mapping;
    using TejeratBankReporting.Core;
    public class TRANSACTIONMap : ClassMap<Transaction> {
        
        public TRANSACTIONMap() {
			Table("TRANSACTIONS");
			LazyLoad();
			Id(x => x.Id).GeneratedBy.Assigned().Column("ID");
			Map(x => x.ACCNO).Column("ACCNO").Not.Nullable();
			Map(x => x.ACTIVEDATE).Column("ACTIVEDATE").Not.Nullable().Length(6);
			Map(x => x.AMOUNT).Column("AMOUNT").Not.Nullable();
			Map(x => x.BALANCE).Column("BALANCE").Not.Nullable();
			Map(x => x.BILLTYPE).Column("BILLTYPE").Not.Nullable().Length(2);
			Map(x => x.CARDNO).Column("CARDNO").Not.Nullable().Length(16);
			Map(x => x.DESCRIPTION).Column("DESCRIPTION").Not.Nullable().Length(100);
			Map(x => x.FEEAMOUNT).Column("FEEAMOUNT").Not.Nullable();
			Map(x => x.FWIMD).Column("FWIMD").Not.Nullable();
			Map(x => x.ID1).Column("ID1").Not.Nullable();
			Map(x => x.ID2).Column("ID2").Not.Nullable();
			Map(x => x.IMD).Column("IMD").Not.Nullable();
			Map(x => x.REGDATE).Column("REGDATE").Not.Nullable().Length(6);
			Map(x => x.REGTIME).Column("REGTIME").Not.Nullable().Length(6);
			Map(x => x.RRN).Column("RRN").Not.Nullable();
			Map(x => x.STAN).Column("STAN").Not.Nullable();
			Map(x => x.STATE).Column("STATE").Not.Nullable();
			Map(x => x.TERMINALID).Column("TERMINALID").Not.Nullable().Length(10);
			Map(x => x.TERMINALTYPE).Column("TERMINALTYPE").Not.Nullable().Length(2);
			Map(x => x.TRANSSIGN).Column("TRANSSIGN").Not.Nullable().Length(1);
			Map(x => x.TRANSTYPE).Column("TRANSTYPE").Not.Nullable().Length(6);
			Map(x => x.TRNDATE).Column("TRNDATE").Not.Nullable();
        }
    }
}
