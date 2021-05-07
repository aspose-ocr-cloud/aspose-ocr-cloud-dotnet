// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OCRRegionsRequestData.cs">
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
    public class OCRRegionsRequestData: OCRRequestData
    {
        private DsrMode dsrMode = Model.DsrMode.NoDsrNoFilter;
        private List<OCRRegion> regions;

        /// <summary>
        /// Region on image to recognize in specific format. <see cref="OCRRegion"/>
        /// </summary>
        public List<OCRRegion> Regions
        {
            get => regions;
            set
            {
                if (value != null && value.Count > 0 && DsrMode != Model.DsrMode.NoDsrNoFilter)
                {
                    // todo make prapper warning
                    Debug.WriteLine(
                        "DsrMode auto forced to Disabled (NoDsrNoFilter). Specific recognition regions selection is incompatible with option of DsrMode.NoDsrNoFilter. Enable DSR with DsrMode property.");
                    DsrMode = Model.DsrMode.NoDsrNoFilter;
                }

                regions = value;
            }
        }

        /// <summary>
        /// An option to switch DSR algorithm
        /// </summary>
        public new Model.DsrMode DsrMode
        {
            get => dsrMode;
            set
            {
                if (value != Model.DsrMode.NoDsrNoFilter && Regions != null && Regions.Count > 0)
                    Debug.WriteLine(
                        "Enabling DSR is incompatible with option of specific recognition regions selection. Set Regions to null or empty.");
                dsrMode = value;
            }
        }
    }
}
