/*
 * Cascade Labs - Shared OCI S3 Client
 * Single AmazonS3Client configured for OCI Object Storage (S3-compatible API).
 * Used by all Cascade data sources that need OCI S3 access.
 */

using QuantConnect.Lean.Engine.Storage;

namespace QuantConnect.Lean.DataSource.HyperliquidData
{
    /// <summary>
    /// Backwards-compatible wrapper over the shared engine CascadeS3Client.
    /// </summary>
    public class CascadeS3Client : QuantConnect.Lean.Engine.Storage.CascadeS3Client
    {
    }
}
