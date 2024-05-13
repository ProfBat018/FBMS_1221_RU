using System;
using System.Collections.Generic;

namespace FirstDockerApp;

public partial class Datatype
{
    public int Int { get; set; }

    public byte? TinyInt { get; set; }

    public short? SmallInt { get; set; }

    public long? BigInt { get; set; }

    public bool? Bit { get; set; }

    public decimal? Decimal { get; set; }

    public decimal? Numeric { get; set; }

    public double? Float { get; set; }

    public float? Real { get; set; }

    public decimal? SmallMoney { get; set; }

    public decimal? Money { get; set; }

    public string? Char { get; set; }

    public string? Nchar { get; set; }

    public string? VarChar { get; set; }

    public string? VarCharMax { get; set; }

    public string? Nvarchar { get; set; }

    public string? NvarcharMax { get; set; }

    public string? Text { get; set; }

    public string? Ntext { get; set; }

    public DateOnly? Date { get; set; }

    public DateTime? SmallDt { get; set; }

    public TimeOnly? Time { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public DateTime? Datetime { get; set; }

    public DateTime? Datetime2 { get; set; }

    public DateTimeOffset? DatetimeOff { get; set; }

    public byte[]? Binary { get; set; }

    public byte[]? Varbin { get; set; }

    public byte[]? VarbinMax { get; set; }

    public byte[]? Image { get; set; }

    public object? SqlVar { get; set; }

    public Guid? Uid { get; set; }

    public string? Xml { get; set; }
}
