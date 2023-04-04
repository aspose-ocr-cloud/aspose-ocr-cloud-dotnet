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
    /// Result document type for Table OCR process
    /// </summary>
    /// <value>Result document type for Table OCR process</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResultTypeTable
    {
        /// <summary>
        /// Enum Text for value: Text
        /// </summary>
        [EnumMember(Value = "Text")]
        Text = 1,

        /// <summary>
        /// Enum Excel for value: Excel
        /// </summary>
        [EnumMember(Value = "Excel")]
        Excel = 2,

        /// <summary>
        /// Enum Csv for value: Csv
        /// </summary>
        [EnumMember(Value = "Csv")]
        Csv = 3

    }

}