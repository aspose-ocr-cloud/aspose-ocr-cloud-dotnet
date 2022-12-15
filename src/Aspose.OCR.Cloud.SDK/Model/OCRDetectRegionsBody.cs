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
    /// Combines Image data and OCR Recognition settings
    /// </summary>
    [DataContract(Name = "OCRDetectRegionsBody")]
    public partial class OCRDetectRegionsBody : IEquatable<OCRDetectRegionsBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OCRDetectRegionsBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OCRDetectRegionsBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OCRDetectRegionsBody" /> class.
        /// </summary>
        /// <param name="image">Gets or Sets Image (required).</param>
        /// <param name="settings">settings (required).</param>
        public OCRDetectRegionsBody(byte[] image = default(byte[]), OCRSettingsDetectRegions settings = default(OCRSettingsDetectRegions))
        {
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new ArgumentNullException("image is a required property for OCRDetectRegionsBody and cannot be null");
            }
            this.Image = image;
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new ArgumentNullException("settings is a required property for OCRDetectRegionsBody and cannot be null");
            }
            this.Settings = settings;
        }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        /// <value>Gets or Sets Image</value>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
        public byte[] Image { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", IsRequired = true, EmitDefaultValue = true)]
        public OCRSettingsDetectRegions Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OCRDetectRegionsBody {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as OCRDetectRegionsBody);
        }

        /// <summary>
        /// Returns true if OCRDetectRegionsBody instances are equal
        /// </summary>
        /// <param name="input">Instance of OCRDetectRegionsBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OCRDetectRegionsBody input)
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
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
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
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
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
