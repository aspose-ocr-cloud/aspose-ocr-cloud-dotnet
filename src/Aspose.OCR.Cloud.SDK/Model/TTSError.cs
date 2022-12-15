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
    /// Error to return to SDK client
    /// </summary>
    [DataContract(Name = "TTSError")]
    public partial class TTSError : IEquatable<TTSError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTSError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TTSError()
        {
        }

        /// <summary>
        /// A list of various clear descriptions of the errors
        /// </summary>
        /// <value>A list of various clear descriptions of the errors</value>
        [DataMember(Name = "messages", EmitDefaultValue = true)]
        public List<string> Messages { get; private set; }

        /// <summary>
        /// Returns false as Messages should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMessages()
        {
            return false;
        }
        /// <summary>
        /// Warning messages - non critical errors: e.g. some data lost
        /// </summary>
        /// <value>Warning messages - non critical errors: e.g. some data lost</value>
        [DataMember(Name = "warnings", EmitDefaultValue = true)]
        public List<string> Warnings { get; private set; }

        /// <summary>
        /// Returns false as Warnings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWarnings()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TTSError {\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TTSError);
        }

        /// <summary>
        /// Returns true if TTSError instances are equal
        /// </summary>
        /// <param name="input">Instance of TTSError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TTSError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    input.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Messages != null)
                {
                    hashCode = (hashCode * 59) + this.Messages.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
