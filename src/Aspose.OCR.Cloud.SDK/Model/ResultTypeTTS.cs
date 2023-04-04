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
    /// Text-to-speech output types
    /// </summary>
    /// <value>Text-to-speech output types</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResultTypeTTS
    {
        /// <summary>
        /// Enum Wav for value: Wav
        /// </summary>
        [EnumMember(Value = "Wav")]
        Wav = 1

    }

}