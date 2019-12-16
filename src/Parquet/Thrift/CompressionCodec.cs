#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

namespace Parquet.Thrift
{
  /// <summary>
  /// Supported compression algorithms.
  /// 
  /// Codecs added in 2.4 can be read by readers based on 2.4 and later.
  /// Codec support may vary between readers based on the format version and
  /// libraries available at runtime. Gzip, Snappy, and LZ4 codecs are
  /// widely available, while Zstd and Brotli require additional libraries.
  /// </summary>
  public enum CompressionCodec
  {
    UNCOMPRESSED = 0,
    SNAPPY = 1,
    GZIP = 2,
    LZO = 3,
    BROTLI = 4,
    LZ4 = 5,
    ZSTD = 6,
  }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member