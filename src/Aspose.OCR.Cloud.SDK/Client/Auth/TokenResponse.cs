/*
 * Aspose OCR Cloud 5.0 API
 *
 * Aspose OCR Cloud 5.0 API
 *


 */


using Newtonsoft.Json;

namespace Aspose.OCR.Cloud.SDK.Client.Auth
{
    class TokenResponse
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}