// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OCRRequestData.cs">
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

namespace Aspose.Ocr.Cloud.Sdk.Model 
{
    /// <summary>
    /// Request data to recognize specific regions on image.
    /// </summary>
    public class OCRRequestData
    {
        /// <summary>
        /// Recognition language. English by default. <see cref="Model.LanguageEnum"/>
        /// </summary>
        public Model.LanguageEnum Language { get; set; } =
            Model.LanguageEnum.English;

        /// <summary>
        /// Option to enable skew correction algorithm. False bt default, because DSR_Step_2 request
        /// </summary>
        public bool MakeSkewCorrect { get; set; } = false;
        
        /// <summary>
        /// Option to enable spell checking and correction algorithm. False by default
        /// </summary>
        public bool MakeSpellCheck { get; set; } = false;

        /// <summary>
        /// An option to switch DSR algorithm
        /// </summary>
        public Model.DsrMode DsrMode { get; set; }
        
        /// <summary>
        /// Region filtering threshold. Filtering by the algorithm confidence scale. Higher mode - more aggressive filtering. Default == Medium
        /// </summary>
        public DsrConfidence DsrConfidence { get; set; } = DsrConfidence.Default;
        
        /// <summary>
        /// Option that sets the recognition result type or combination of some types: Text, Searchable PDF, HOCR
        /// </summary>
        public Model.ResultType ResultType { get; set; } = Model.ResultType.Text;

        /// Option to enable contrastCorrection algorithm. False by default
        /// </summary>
        public bool ContrastCorrection { get; set; } = false;

        /// <summary>
        /// MakeImageUpscaling
        /// </summary>
        public bool MakeImageUpscaling { get; set; } = false;
    }
}