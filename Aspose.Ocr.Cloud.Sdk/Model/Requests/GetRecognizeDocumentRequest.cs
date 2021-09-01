
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetRecognizeDocumentRequest.cs">
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
    /// <summary>
  /// Request model for <see cref="Aspose.Ocr.Cloud.Sdk.Api.OcrApi.GetRecognizeDocument" /> operation.
  /// </summary>  
  public class GetRecognizeDocumentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecognizeDocumentRequest"/> class.
        /// </summary>        
        public GetRecognizeDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecognizeDocumentRequest"/> class.
        /// </summary>
        /// <param name="name">Name of the file to recognize.</param>
        /// <param name="storage">The image storage.</param>
        /// <param name="folder">The image folder.</param>
        /// <param name="language">Prior recognition language selection</param>
        /// <param name="resultType">Option that sets the recognition result type or combination of some types: Text, Searchable PDF, HOCR</param>
        /// <param name="dsrMode">An option to switch DSR algorithm</param>
        public GetRecognizeDocumentRequest(
            string name, 
            string storage = null, 
            string folder = null, 
            LanguageEnum? language = null, 
            ResultType? resultType = null,
            bool skewCorrect = true,
            bool spellCheck = false,
            bool contrastCorrection = false,
            DsrMode? dsrMode = null,
            DsrConfidence? dsrConfidence = null)             
        {
            this.name = name;
            this.storage = storage;
            this.folder = folder;
            this.language = language;
            this.resultType = resultType;
            this.skewCorrect = skewCorrect;
            this.spellCheck = spellCheck;
            this.contrastCorrection = contrastCorrection;
            this.dsrMode = dsrMode;
            this.dsrConfidence = dsrConfidence;
        }

        /// <summary>
        /// Name of the file to recognize.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The image storage.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// The image folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Prior recognition language
        /// </summary>  
        public LanguageEnum? language { get; set; }

        /// <summary>
        /// Option that sets the recognition result type or combination of some types: Text, Searchable PDF, HOCR
        /// </summary>
        public ResultType? resultType { get; set; }
        
        /// <summary>
        /// Option to enable skew correction algorithm. False by default, because DSR_Step_2 request
        /// </summary>
        public bool skewCorrect { get; set; }

        /// <summary>
        /// Option to enable spell checking and correction algorithm. False by default
        /// </summary>
        public bool spellCheck { get; set; }

        /// <summary>
        /// Option to enable image contrast correction for low contrast photos. False by default
        /// </summary>
        public bool contrastCorrection { get; set; }

        /// <summary>
        /// An option to switch DSR algorithm
        /// </summary>
        public DsrMode? dsrMode { get; set; }
        
        /// <summary>
        /// Region filtering threshold. Filtering by the algorithm confidence scale. Higher mode - more aggressive filtering. Default == Medium
        /// </summary>
        public DsrConfidence? dsrConfidence { get; set; }
    }
}