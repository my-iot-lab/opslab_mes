﻿namespace Admin.NET.Application.Entity;

/// <summary>
/// 关键物料追溯信息
/// </summary>
[SugarTable("ops_track_material", "关键物料追溯信息表")]
public class TrackMaterial : BizEntityBaseId
{
    /// <summary>
    /// SN
    /// </summary>
    [SugarColumn(ColumnDescription = "SN", Length = 64)]
    [Required, MaxLength(64)]
    [NotNull]
    public string? SN { get; set; }

    /// <summary>
    /// SN
    /// </summary>
    [SugarColumn(ColumnDescription = "SN", Length = 64)]
    [Required, MaxLength(64)]
    [NotNull]
    public string? Barcode { get; set; }

    /// <summary>
    /// 扫描时间
    /// </summary>
    [SugarColumn(ColumnDescription = "扫描时间")]
    public DateTime CreatedAt { get; set; }
}
