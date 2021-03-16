
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostOcrFromUrlOrContentRequest.cs">
//   Copyright (c) 2019 Aspose.Ocr for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Aspose.Ocr.Cloud.Sdk.Model.Requests 
{
  using Aspose.Ocr.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Ocr.Cloud.Sdk.Api.OcrApi.PostOcrFromUrlOrContent" /> operation.
  /// </summary>  
  public class PostOcrFromUrlOrContentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostOcrFromUrlOrContentRequest"/> class.
        /// </summary>        
        public PostOcrFromUrlOrContentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOcrFromUrlOrContentRequest"/> class.
        /// </summary>
        /// <param name="file">File to upload</param>
        /// <param name="url">The image file url.</param>
        /// <param name="language">Prior recognition language selection</param>
        /// <param name="resultType">Option that sets the recognition result type or combination of some types: Text, Searchable PDF, HOCR</param>
        /// <param name="dsrMode">An option to switch DSR algorithm</param>
        public PostOcrFromUrlOrContentRequest(
            System.IO.Stream file, 
            string url = null,
            LanguageEnum? language = null,
            ResultType? resultType = null,
            DsrMode? dsrMode = null)
        {
            this.File = file;
            this.url = url;
            this.language = language;
            this.resultType = resultType;
            this.dsrMode = dsrMode;
        }

        /// <summary>
        /// File to upload
        /// </summary>  
        public System.IO.Stream File { get; set; }

        /// <summary>
        /// The image file url.
        /// </summary>  
        public string url { get; set; }

        /// <summary>
        /// Prior recognition language
        /// </summary>  
        public LanguageEnum? language { get; set; }

        /// <summary>
        /// Option that sets the recognition result type or combination of some types: Text, Searchable PDF, HOCR
        /// </summary>
        public ResultType? resultType { get; set; }

        /// <summary>
        /// An option to switch DSR algorithm
        /// </summary>
        public DsrMode? dsrMode { get; set; }
    }
}
