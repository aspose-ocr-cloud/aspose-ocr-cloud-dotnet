/*
 * Aspose OCR Cloud 5.0 API
 *
 * Aspose OCR Cloud 5.0 API
 *
 * The version of the OpenAPI document: 5.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
    /// Combines Image data and OCR processing settings
    /// </summary>
    [DataContract(Name = "OCRUpscaleImageBody")]
    public partial class OCRUpscaleImageBody : IEquatable<OCRUpscaleImageBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OCRUpscaleImageBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OCRUpscaleImageBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OCRUpscaleImageBody" /> class.
        /// </summary>
        /// <param name="image">Gets or Sets Image (required).</param>
        public OCRUpscaleImageBody(byte[] image = default(byte[]))
        {
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new ArgumentNullException("image is a required property for OCRUpscaleImageBody and cannot be null");
            }
            this.Image = image;
        }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        /// <value>Gets or Sets Image</value>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
        public byte[] Image { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OCRUpscaleImageBody {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
            return this.Equals(input as OCRUpscaleImageBody);
        }

        /// <summary>
        /// Returns true if OCRUpscaleImageBody instances are equal
        /// </summary>
        /// <param name="input">Instance of OCRUpscaleImageBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OCRUpscaleImageBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
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
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
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
