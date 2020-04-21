using System;
using Newtonsoft.Json;
using NPoco;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Velum.Web.Domain.CurrencyRates
{
    [TableName("Currency")]
    [PrimaryKey("Id", AutoIncrement = false)]
    public class Currency
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