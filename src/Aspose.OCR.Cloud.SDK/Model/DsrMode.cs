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
    /// Option that sets the recognition result type or combination of some types: Text, Searchable PDF, HOCR
    /// </summary>
    /// <value>Option that sets the recognition result type or combination of some types: Text, Searchable PDF, HOCR</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DsrMode
    {
        /// <summary>
        /// Enum Regions for value: Regions
        /// </summary>
        [EnumMember(Value = "Regions")]
        Regions = 1,

        /// <summary>
        /// Enum DsrNoFilter for value: DsrNoFilter
        /// </summary>
        [EnumMember(Value = "DsrNoFilter")]
        DsrNoFilter = 2,

        /// <summary>
        /// Enum DsrAndFilter for value: DsrAndFilter
        /// </summary>
        [EnumMember(Value = "DsrAndFilter")]
        DsrAndFilter = 3,

        /// <summary>
        /// Enum NoDsrNoFilter for value: NoDsrNoFilter
        /// </summary>
        [EnumMember(Value = "NoDsrNoFilter")]
        NoDsrNoFilter = 4,

        /// <summary>
        /// Enum TextDetector for value: TextDetector
        /// </summary>
        [EnumMember(Value = "TextDetector")]
        TextDetector = 5,

        /// <summary>
        /// Enum DsrPlusDetector for value: DsrPlusDetector
        /// </summary>
        [EnumMember(Value = "DsrPlusDetector")]
        DsrPlusDetector = 6

    }

}