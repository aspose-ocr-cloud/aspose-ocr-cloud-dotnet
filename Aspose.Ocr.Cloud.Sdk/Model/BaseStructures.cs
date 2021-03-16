// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BaseStructures.cs">
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

using System;

namespace Aspose.Ocr.Cloud.Sdk.Model 
{
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;
  
  /// <summary>
  /// Prior recognition language
  /// </summary>  
  [JsonConverter(typeof(StringEnumConverter))]
  public  enum LanguageEnum 
  {  	
		/// <summary>
        /// Set English language for OCR
        /// </summary>            
        English = 1,

        /// <summary>
        /// Set German language for OCR
        /// </summary>            
        German = 2,

        /// <summary>
        /// Set French language for OCR
        /// </summary>            
        French = 3,

        /// <summary>
        /// Set Italian language for OCR
        /// </summary>
        Italian = 4,

        /// <summary>
        /// Set Spanish language for OCR
        /// </summary>
        Spanish = 5,

        /// <summary>
        /// Set Portuguese language for OCR
        /// </summary>
        Portuguese = 6
  }

  /// <summary>
  /// Flag option to set one ore some rescognition result types
  /// </summary>
  [Flags]
  public enum ResultType
  {
        /// <summary>
        /// Plain text
        /// </summary>
        Text = 1, 

        /// <summary>
        /// Searchable PDF
        /// </summary>
        Pdf = 2,  

        /// <summary>
        /// HOCR
        /// </summary>
        HOCR = 4,
        
        Internal = 8
  }

  /// <summary>
  /// Option that sets the recognition result type or combination of some types: Text, Searchable PDF, HOCR
  /// </summary>
  public enum DsrMode
  {
        /// <summary>
        /// Use DocumentStructure Recognition algorithm that detects large text areas
        /// </summary>
        DsrNoFilter = 1,

        /// <summary>
        /// Use DocumentStructure Recognition algorithm that detects large text areas with additional automated regions filter
        /// </summary>
        DsrAndFilter = 2,

        /// <summary>
        /// Disable DSR algorithm, If your images are samall or contains only lines of text without other content like images.
        /// </summary>
        NoDsrNoFilter = 3
  }
}
