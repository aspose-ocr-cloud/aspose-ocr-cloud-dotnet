// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OCRRegion.cs">
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

namespace Aspose.Ocr.Cloud.Sdk.Model 
{
    /// <summary>
    /// Represents a rectangle: Left-Top (X1-Y1) to Right-Bottom (X2-Y2)
    /// </summary>
    public class OCRRect
    {
        /// <summary>
        /// Make a rectangle: Left-Top (X1-Y1) to Right-Bottom (X2-Y2)
        /// </summary>
        /// <param name="topLeftX">Left-Top (X1)</param>
        /// <param name="topLeftY">Left-Top (Y1)</param>
        /// <param name="bottomRightX">Right-Bottom (X2)</param>
        /// <param name="bBottomRightY">Right-Bottom (Y2)</param>
        public OCRRect(int topLeftX, int topLeftY, int bottomRightX, int bBottomRightY)
        {
            TopLeftX = topLeftX;
            TopLeftY = topLeftY;
            BottomRightX = bottomRightX;
            BottomRightY = bBottomRightY;
        }
        /// <summary>
        /// X-Coordinate of top left corner
        /// </summary>
        public int TopLeftX { get; set; }

        /// <summary>
        /// Y-Coordinate of top left corner
        /// </summary>
        public int TopLeftY { get; set; }

        /// <summary>
        /// X-Coordinate of bottom right corner
        /// </summary>
        public int BottomRightX { get; set; }

        /// <summary>
        /// Y-Coordinate of bottom right corner
        /// </summary>
        public int BottomRightY { get; set; }

        /// <summary>
        /// Return coordinates as List of integers for internal purpose
        /// </summary>
        /// <returns></returns>
        public List<int> ToIntList()
        {
            return new List<int>(){ TopLeftX, TopLeftY, BottomRightX, BottomRightY };
        }
    }

    /// <summary>
    /// Represents information about strict regions to recognize text 
    /// </summary>
    public class OCRRegion
    {
        /// <summary>
        /// Coordinates of a rectangle to recognize
        /// </summary>
        public OCRRect Rect { get; set; }

        /// <summary>
        /// The serial number of the region for the formation of the text
        /// </summary>
        public int Order { get; set; }
    }
}
