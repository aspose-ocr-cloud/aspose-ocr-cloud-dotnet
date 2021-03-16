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

using System.Collections.Generic;
using System.Diagnostics;

namespace Aspose.Ocr.Cloud.Sdk.Model
{
    /// <summary>
    /// Request data to recognize specific regions on image.
    /// </summary>
    public class OCRRequestData
    {
        private DsrMode dsrMode = DsrMode.NoDsrNoFilter;
        private List<OCRRegion> regions;

        /// <summary>
        /// Region on image to recognize in specific format. <see cref="OCRRegion"/>
        /// </summary>
        public List<OCRRegion> Regions
        {
            get => regions;
            set
            {
                if (value != null && value.Count > 0 && DsrMode != DsrMode.NoDsrNoFilter)
                {
                    // todo make prapper warning
                    Debug.WriteLine(
                        "DsrMode auto forced to Disabled (NoDsrNoFilter). Specific recognition regions selection is incompatiable with option of DsrMode.NoDsrNoFilter. Enable DSR with DsrMode property.");
                    DsrMode = DsrMode.NoDsrNoFilter;
                }

                regions = value;
            }
        }

        /// <summary>
        /// Recognition language. English by default. <see cref="LanguageEnum"/>
        /// </summary>
        public LanguageEnum Language { get; set; } = LanguageEnum.English;

        /// <summary>
        /// Option to enable skew correction algorithm. False bt default, because DSR_Step_2 request
        /// </summary>
        public bool MakeSkewCorrect { get; set; } = false;

        /// <summary>
        /// Option that sets the recognition result type or combination of some types: Text, Searchable PDF, HOCR
        /// </summary>
        public DsrMode DsrMode
        {
            get => dsrMode;
            set
            {
                if (value != DsrMode.NoDsrNoFilter && Regions != null && Regions.Count > 0)
                    // todo make prapper warning
                    Debug.WriteLine(
                        "Enabling DSR is incompatiable with option of specific recognition regions selection. Set Regions to null or empty.");
                dsrMode = value;
            }
        }

        /// <summary>
        /// Option that sets the recognition result type or combination of some types: Text, Searchable PDF, HOCR
        /// </summary>
        public ResultType ResultType { get; set; } = ResultType.Text;
    }
}