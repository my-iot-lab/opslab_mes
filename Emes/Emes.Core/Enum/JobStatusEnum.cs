namespace Emes.Core;

/// <summary>
/// 岗位状态枚举
/// </summary>
public enum JobStatusEnum
{
    /// <summary>
    /// 在职
    /// </summary>
    [Description("在职")]
    On = 1,

    /// <summary>
    /// 离职
    /// </summary>
    [Description("离职")]
    Off = 2,

    /// <summary>
    /// 请假
    /// </summary>
    [Description("请假")]
    Leave = 3,
}