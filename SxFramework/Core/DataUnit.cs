namespace Sx.Core;

/// <summary>
/// Unit constants
/// </summary>
public static class DataUnit
{
    /// <summary>
    /// Kilobytes (KiB) = 1024 bytes
    /// </summary>
    public const int KB = 1024;

    /// <summary>
    /// Megabytes (MiB) = 1048576 bytes
    /// </summary>
    public const int MB = 1024 * KB;

    /// <summary>
    /// Gigabytes (GiB) = 1073741824 bytes
    /// </summary>
    public const int GB = 1024 * MB;

    /// <summary>
    /// Terabytes (TiB) = 1099511627776 bytes
    /// </summary>
    public const long TB = 1024L * GB;
}
