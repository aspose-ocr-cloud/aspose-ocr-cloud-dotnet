/*
 * Aspose OCR Cloud 4.0 API
 *
 * Aspose OCR Cloud 4.0 API
 *
 * The version of the OpenAPI document: 4.0

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
    /// Operation how to process file
    /// </summary>
    /// <value>Operation how to process file</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Pipeline
    {
        /// <summary>
        /// Enum RecognizeImage for value: RecognizeImage
        /// </summary>
        [EnumMember(Value = "RecognizeImage")]
        RecognizeImage = 1,

        /// <summary>
        /// Enum RecognizeTable for value: RecognizeTable
        /// </summary>
        [EnumMember(Value = "RecognizeTable")]
        RecognizeTable = 2,

        /// <summary>
        /// Enum RecognizePdf for value: RecognizePdf
        /// </summary>
        [EnumMember(Value = "RecognizePdf")]
        RecognizePdf = 3,

        /// <summary>
        /// Enum RecognizeReceipt for value: RecognizeReceipt
        /// </summary>
        [EnumMember(Value = "RecognizeReceipt")]
        RecognizeReceipt = 4,

        /// <summary>
        /// Enum RecognizeSvg for value: RecognizeSvg
        /// </summary>
        [EnumMember(Value = "RecognizeSvg")]
        RecognizeSvg = 5,

        /// <summary>
        /// Enum DsrStep1 for value: DsrStep1
        /// </summary>
        [EnumMember(Value = "DsrStep1")]
        DsrStep1 = 6,

        /// <summary>
        /// Enum DsrStep2 for value: DsrStep2
        /// </summary>
        [EnumMember(Value = "DsrStep2")]
        DsrStep2 = 7,

        /// <summary>
        /// Enum SkewCorrection for value: SkewCorrection
        /// </summary>
        [EnumMember(Value = "SkewCorrection")]
        SkewCorrection = 8,

        /// <summary>
        /// Enum Upsampling for value: Upsampling
        /// </summary>
        [EnumMember(Value = "Upsampling")]
        Upsampling = 9,

        /// <summary>
        /// Enum Binarization for value: Binarization
        /// </summary>
        [EnumMember(Value = "Binarization")]
        Binarization = 10,

        /// <summary>
        /// Enum Dewarping for value: Dewarping
        /// </summary>
        [EnumMember(Value = "Dewarping")]
        Dewarping = 11

    }

}
