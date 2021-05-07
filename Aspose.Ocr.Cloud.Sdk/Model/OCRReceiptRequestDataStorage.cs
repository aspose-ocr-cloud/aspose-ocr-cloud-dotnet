// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OCRReceiptRequestDataStorage.cs">
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
    /// Request Form Data for Aspose storage file info
    /// </summary>
    public class OCRReceiptRequestDataStorage : OCRReceiptRequestData
    {
        /// <summary>
        /// Filename that you have already put in Aspose Storage. *Required
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Storage name in Aspose Storage. Null for DefaultStorage
        /// </summary>
        public string Storage { get; set; } = null;
        /// <summary>
        /// Folder name in Aspose Storage. *Null for root folder
        /// </summary>
        public string Folder { get; set; } = null;

    }
}