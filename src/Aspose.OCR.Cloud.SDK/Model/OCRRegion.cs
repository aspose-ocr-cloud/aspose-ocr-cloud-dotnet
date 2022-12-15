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
    /// Represents information about strict regions to recognize text
    /// </summary>
    [DataContract(Name = "OCRRegion")]
    public partial class OCRRegion : IEquatable<OCRRegion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OCRRegion" /> class.
        /// </summary>
        /// <param name="rect">rect.</param>
        /// <param name="order">The serial number of the region for the formation of the text.</param>
        public OCRRegion(OCRRect rect = default(OCRRect), int order = default(int))
        {
            this.Rect = rect;
            this.Order = order;
        }

        /// <summary>
        /// Gets or Sets Rect
        /// </summary>
        [DataMember(Name = "rect", EmitDefaultValue = false)]
        public OCRRect Rect { get; set; }

        /// <summary>
        /// The serial number of the region for the formation of the text
        /// </summary>
        /// <value>The serial number of the region for the formation of the text</value>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OCRRegion {\n");
            sb.Append("  Rect: ").Append(Rect).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as OCRRegion);
        }

        /// <summary>
        /// Returns true if OCRRegion instances are equal
        /// </summary>
        /// <param name="input">Instance of OCRRegion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OCRRegion input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Rect == input.Rect ||
                    (this.Rect != null &&
                    this.Rect.Equals(input.Rect))
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
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
                if (this.Rect != null)
                {
                    hashCode = (hashCode * 59) + this.Rect.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
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
