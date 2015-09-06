using System.Collections.Generic;

namespace NPoco.Tests.NewMapper.Models
{
    [TableName("Ones"), PrimaryKey("OneId")]
    public class One
    {
        public int OneId { get; set; }
        public string Name { get; set; }

        [ResultColumn, ComplexMapping]
        public NestedClass Nested { get; set; }

        [Reference(ReferenceType.Many, ColumnName = "OneId", ReferenceMemberName = "OneId")]
        public List<Many> Items { get; set; }
    }

    public class NestedClass
    {
        public string Name { get; set; }
    }
}