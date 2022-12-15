/*
 * Aspose OCR Cloud 5.0 API
 *
 * Aspose OCR Cloud 5.0 API
 *


 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Aspose.OCR.Cloud.SDK.Client.OpenAPIDateConverter;

namespace Aspose.OCR.Cloud.SDK.Model
{
    /// <summary>
    /// Result document type for OCR process
    /// </summary>
    /// <value>Result document type for OCR process</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResultType
    {
        /// <summary>
        /// Enum Text for value: Text
        /// </summary>
        [EnumMember(Value = "Text")]
        Text = 1,

        /// <summary>
        /// Enum Pdf for value: Pdf
        /// </summary>
        [EnumMember(Value = "Pdf")]
        Pdf = 2,

        /// <summary>
        /// Enum TextAndPdf for value: TextAndPdf
        /// </summary>
        [EnumMember(Value = "TextAndPdf")]
        TextAndPdf = 3,

        /// <summary>
        /// Enum Hocr for value: Hocr
        /// </summary>
        [EnumMember(Value = "Hocr")]
        Hocr = 4,

        /// <summary>
        /// Enum TextAndHocr for value: TextAndHocr
        /// </summary>
        [EnumMember(Value = "TextAndHocr")]
        TextAndHocr = 5,

        /// <summary>
        /// Enum PdfAndHocr for value: PdfAndHocr
        /// </summary>
        [EnumMember(Value = "PdfAndHocr")]
        PdfAndHocr = 6,

        /// <summary>
        /// Enum TextAndPdfAndHocr for value: TextAndPdfAndHocr
        /// </summary>
        [EnumMember(Value = "TextAndPdfAndHocr")]
        TextAndPdfAndHocr = 7,

        /// <summary>
        /// Enum ImagePNG for value: ImagePNG
        /// </summary>
        [EnumMember(Value = "ImagePNG")]
        ImagePNG = 8

    }

}
