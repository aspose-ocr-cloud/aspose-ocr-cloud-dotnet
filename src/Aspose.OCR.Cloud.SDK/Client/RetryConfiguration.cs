/*
 * Aspose OCR Cloud 5.0 API
 *
 * Aspose OCR Cloud 5.0 API
 *


 */


using Polly;
using RestSharp;

namespace Aspose.OCR.Cloud.SDK.Client
{
    /// <summary>
    /// Configuration class to set the polly retry policies to be applied to the requests.
    /// </summary>
    public static class RetryConfiguration
    {
        /// <summary>
        /// Retry policy
        /// </summary>
        public static Policy<RestResponse> RetryPolicy { get; set; }

        /// <summary>
        /// Async retry policy
        /// </summary>
        public static AsyncPolicy<RestResponse> AsyncRetryPolicy { get; set; }
    }
}
