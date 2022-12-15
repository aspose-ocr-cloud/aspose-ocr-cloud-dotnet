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
    /// PostTextToSpeechRequest
    /// </summary>
    [DataContract(Name = "PostTextToSpeech_request")]
    public partial class PostTextToSpeechRequest : IEquatable<PostTextToSpeechRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "Language", IsRequired = true, EmitDefaultValue = true)]
        public LanguageTTS Language { get; set; }

        /// <summary>
        /// Gets or Sets ResultType
        /// </summary>
        [DataMember(Name = "ResultType", IsRequired = true, EmitDefaultValue = true)]
        public ResultTypeTTS ResultType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostTextToSpeechRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostTextToSpeechRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostTextToSpeechRequest" /> class.
        /// </summary>
        /// <param name="text">Input text (required).</param>
        /// <param name="language">language (required).</param>
        /// <param name="resultType">resultType (required).</param>
        public PostTextToSpeechRequest(string text = default(string), LanguageTTS language = default(LanguageTTS), ResultTypeTTS resultType = default(ResultTypeTTS))
        {
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for PostTextToSpeechRequest and cannot be null");
            }
            this.Text = text;
            this.Language = language;
            this.ResultType = resultType;
        }

        /// <summary>
        /// Input text
        /// </summary>
        /// <value>Input text</value>
        [DataMember(Name = "Text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostTextToSpeechRequest {\n");
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
            return this.Equals(input as PostTextToSpeechRequest);
        }

        /// <summary>
        /// Returns true if PostTextToSpeechRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostTextToSpeechRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostTextToSpeechRequest input)
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
            // Text (string) maxLength
            if (this.Text != null && this.Text.Length > 1200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Text, length must be less than 1200.", new [] { "Text" });
            }

            yield break;
        }
    }

}
