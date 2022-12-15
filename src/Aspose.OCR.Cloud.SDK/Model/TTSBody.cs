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
    /// Represents input text data with settings
    /// </summary>
    [DataContract(Name = "TTSBody")]
    public partial class TTSBody : IEquatable<TTSBody>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", IsRequired = true, EmitDefaultValue = true)]
        public LanguageTTS Language { get; set; }

        /// <summary>
        /// Gets or Sets ResultType
        /// </summary>
        [DataMember(Name = "resultType", IsRequired = true, EmitDefaultValue = true)]
        public ResultTypeTTS ResultType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TTSBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TTSBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TTSBody" /> class.
        /// </summary>
        /// <param name="text">Gets or Sets text (required).</param>
        /// <param name="language">language (required).</param>
        /// <param name="resultType">resultType (required).</param>
        public TTSBody(string text = default(string), LanguageTTS language = default(LanguageTTS), ResultTypeTTS resultType = default(ResultTypeTTS))
        {
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for TTSBody and cannot be null");
            }
            this.Text = text;
            this.Language = language;
            this.ResultType = resultType;
        }

        /// <summary>
        /// Gets or Sets text
        /// </summary>
        /// <value>Gets or Sets text</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TTSBody {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ResultType: ").Append(ResultType).Append("\n");
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
            return this.Equals(input as TTSBody);
        }

        /// <summary>
        /// Returns true if TTSBody instances are equal
        /// </summary>
        /// <param name="input">Instance of TTSBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TTSBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Language == input.Language ||
                    this.Language.Equals(input.Language)
                ) && 
                (
                    this.ResultType == input.ResultType ||
                    this.ResultType.Equals(input.ResultType)
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
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Language.GetHashCode();
                hashCode = (hashCode * 59) + this.ResultType.GetHashCode();
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
            // Text (string) minLength
            if (this.Text != null && this.Text.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Text, length must be greater than 1.", new [] { "Text" });
            }

            yield break;
        }
    }

}
