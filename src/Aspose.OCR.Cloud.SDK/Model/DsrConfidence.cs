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
    /// Region filtering threshold. Filtering by the algorithm confidence scale. Higher mode - more aggressive filtering. Default &#x3D;&#x3D; Medium
    /// </summary>
    /// <value>Region filtering threshold. Filtering by the algorithm confidence scale. Higher mode - more aggressive filtering. Default &#x3D;&#x3D; Medium</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DsrConfidence
    {
        /// <summary>
        /// Enum Default for value: Default
        /// </summary>
        [EnumMember(Value = "Default")]
        Default = 1,

        /// <summary>
        /// Enum Low for value: Low
        /// </summary>
        [EnumMember(Value = "Low")]
        Low = 2,

        /// <summary>
        /// Enum LowMid for value: LowMid
        /// </summary>
        [EnumMember(Value = "LowMid")]
        LowMid = 3,

        /// <summary>
        /// Enum Mid for value: Mid
        /// </summary>
        [EnumMember(Value = "Mid")]
        Mid = 4,

        /// <summary>
        /// Enum MidHigh for value: MidHigh
        /// </summary>
        [EnumMember(Value = "MidHigh")]
        MidHigh = 5,

        /// <summary>
        /// Enum High for value: High
        /// </summary>
        [EnumMember(Value = "High")]
        High = 6,

        /// <summary>
        /// Enum Ultra for value: Ultra
        /// </summary>
        [EnumMember(Value = "Ultra")]
        Ultra = 7,

        /// <summary>
        /// Enum All for value: All
        /// </summary>
        [EnumMember(Value = "All")]
        All = 8

    }

}