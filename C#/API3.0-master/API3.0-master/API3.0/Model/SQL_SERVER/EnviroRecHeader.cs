using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API3._0.Model.SQL_SERVER
{
    [Table("EnviroRecHeader")]
    public class EnviroRecHeader
    {
        [Key]
        public int Id { get; set; }

        public string? Description { get; set; }

        public int Channel { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? StopTime { get; set; }

        public int? MeasureUnit { get; set; }
    }
}
