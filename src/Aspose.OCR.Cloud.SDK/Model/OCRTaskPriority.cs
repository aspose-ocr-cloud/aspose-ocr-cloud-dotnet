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
    /// Task priority for message broker queries (NMS Message Priority)  This is a copy of Apache.NMS.MsgPriority
    /// </summary>
    /// <value>Task priority for message broker queries (NMS Message Priority)  This is a copy of Apache.NMS.MsgPriority</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OCRTaskPriority
    {
        /// <summary>
        /// Enum Lowest for value: Lowest
        /// </summary>
        [EnumMember(Value = "Lowest")]
        Lowest = 1,

        /// <summary>
        /// Enum VeryLow for value: VeryLow
        /// </summary>
        [EnumMember(Value = "VeryLow")]
        VeryLow = 2,

        /// <summary>
        /// Enum Low for value: Low
        /// </summary>
        [EnumMember(Value = "Low")]
        Low = 3,

        /// <summary>
        /// Enum AboveLow for value: AboveLow
        /// </summary>
        [EnumMember(Value = "AboveLow")]
        AboveLow = 4,

        /// <summary>
        /// Enum BelowNormal for value: BelowNormal
        /// </summary>
        [EnumMember(Value = "BelowNormal")]
        BelowNormal = 5,

        /// <summary>
        /// Enum Normal for value: Normal
        /// </summary>
        [EnumMember(Value = "Normal")]
        Normal = 6,

        /// <summary>
        /// Enum AboveNormal for value: AboveNormal
        /// </summary>
        [EnumMember(Value = "AboveNormal")]
        AboveNormal = 7,

        /// <summary>
        /// Enum High for value: High
        /// </summary>
        [EnumMember(Value = "High")]
        High = 8,

        /// <summary>
        /// Enum VeryHigh for value: VeryHigh
        /// </summary>
        [EnumMember(Value = "VeryHigh")]
        VeryHigh = 9,

        /// <summary>
        /// Enum Highest for value: Highest
        /// </summary>
        [EnumMember(Value = "Highest")]
        Highest = 10

    }

}
