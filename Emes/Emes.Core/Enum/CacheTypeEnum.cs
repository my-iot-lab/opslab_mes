namespace Emes.Core;

/// <summary>
/// 缓存类型枚举
/// </summary>
public enum CacheTypeEnum
{
    /// <summary>
    /// 内存缓存
    /// </summary>
    [Description("内存缓存")]
    MemoryCache,

    /// <summary>
    /// Redis缓存
    /// </summary>
    [Description("Redis缓存")]
    RedisCache
}