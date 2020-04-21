using System;
using Umbraco.Core.Logging;
using Umbraco.Core.Migrations;
using NPoco;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Velum.Web.Composers.Migrations
{
    public class AddCurrencyTable : MigrationBase
    {
        public AddCurrencyTable(IMigrationContext context) : base(context)
        {
        }

        public override void Migrate()
        {
            Logger.Debug<AddCurrencyTable>("Running migration {MigrationStep}", "AddCommentsTable");

            // Lots of methods available in the MigrationBase class - discover with this.
            if (TableExists("Currency") == false)
            {
                Create.Table<CurrencyScheme>().Do();
            }
            else
            {
                Logger.Debug<AddCurrencyTable>("The database table {DbTable} already exists, skipping", "Currency");
            }
        }

        [TableName("Currency")]
        [PrimaryKey("Id", AutoIncrement = false)]
        [ExplicitColumns]
        public class CurrencyScheme
        {
            [PrimaryKeyColumn(AutoIncrement = false)]
            [Column("id")] public int Id { get; set; }

            [Column("parent_id")]
            public int? ParentId { get; set; }

            [Column("code")]
            public string Code { get; set; }

            [Column("abbreviation")]
            public string Abbreviation { get; set; }

            [Column("name")]
            public string Name { get; set; }

            [Column("name_bel")]
            public string NameBel { get; set; }

            [Column("name_eng")]
            public string NameEng { get; set; }

            [Column("quot_name")]
            public string QuotName { get; set; }

            [Column("quot_name_bel")]
            public string QuotNameBel { get; set; }

            [Column("quot_name_eng")]
            public string QuotNameEng { get; set; }

            [Column("name_multi")]
            public string NameMulti { get; set; }

            [Column("name_bel_multi")]
            public string NameBelMulti { get; set; }

            [Column("name_eng_multi")]
            public string NameEngMulti { get; set; }

            [Column("scale")]
            public int Scale { get; set; }

            [Column("periodicity")]
            public int Periodicity { get; set; }

            [Column("date_start")]
            public DateTime DateStart { get; set; }

            [Column("date_end")]
            public DateTime DateEnd { get; set; }
        }
    }
}