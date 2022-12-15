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
    /// Status code showing the status of the request, operation, and result processing.
    /// </summary>
    /// <value>Status code showing the status of the request, operation, and result processing.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResponseStatusCode
    {
        /// <summary>
        /// Enum Ok for value: Ok
        /// </summary>
        [EnumMember(Value = "Ok")]
        Ok = 1,

        /// <summary>
        /// Enum PartiallyNotFound for value: PartiallyNotFound
        /// </summary>
        [EnumMember(Value = "PartiallyNotFound")]
        PartiallyNotFound = 2,

        /// <summary>
        /// Enum NoAnyResultData for value: NoAnyResultData
        /// </summary>
        [EnumMember(Value = "NoAnyResultData")]
        NoAnyResultData = 3,

        /// <summary>
        /// Enum ResultDataLost for value: ResultDataLost
        /// </summary>
        [EnumMember(Value = "ResultDataLost")]
        ResultDataLost = 4,

        /// <summary>
        /// Enum TaskNotFound for value: TaskNotFound
        /// </summary>
        [EnumMember(Value = "TaskNotFound")]
        TaskNotFound = 5,

        /// <summary>
        /// Enum NotReady for value: NotReady
        /// </summary>
        [EnumMember(Value = "NotReady")]
        NotReady = 6,

        /// <summary>
        /// Enum Error for value: Error
        /// </summary>
        [EnumMember(Value = "Error")]
        Error = 7

    }

}
