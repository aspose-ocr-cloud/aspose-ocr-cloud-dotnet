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
    /// Represents a rectangle: Left-Top (X1-Y1) to Right-Bottom (X2-Y2)
    /// </summary>
    [DataContract(Name = "OCRRect")]
    public partial class OCRRect : IEquatable<OCRRect>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OCRRect" /> class.
        /// </summary>
        /// <param name="topLeftX">X-Coordinate of top left corner.</param>
        /// <param name="topLeftY">Y-Coordinate of top left corner.</param>
        /// <param name="bottomRightX">X-Coordinate of bottom right corner.</param>
        /// <param name="bottomRightY">Y-Coordinate of bottom right corner.</param>
        public OCRRect(int topLeftX = default(int), int topLeftY = default(int), int bottomRightX = default(int), int bottomRightY = default(int))
        {
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
            this.BottomRightX = bottomRightX;
            this.BottomRightY = bottomRightY;
        }

        /// <summary>
        /// X-Coordinate of top left corner
        /// </summary>
        /// <value>X-Coordinate of top left corner</value>
        [DataMember(Name = "topLeftX", EmitDefaultValue = false)]
        public int TopLeftX { get; set; }

        /// <summary>
        /// Y-Coordinate of top left corner
        /// </summary>
        /// <value>Y-Coordinate of top left corner</value>
        [DataMember(Name = "topLeftY", EmitDefaultValue = false)]
        public int TopLeftY { get; set; }

        /// <summary>
        /// X-Coordinate of bottom right corner
        /// </summary>
        /// <value>X-Coordinate of bottom right corner</value>
        [DataMember(Name = "bottomRightX", EmitDefaultValue = false)]
        public int BottomRightX { get; set; }

        /// <summary>
        /// Y-Coordinate of bottom right corner
        /// </summary>
        /// <value>Y-Coordinate of bottom right corner</value>
        [DataMember(Name = "bottomRightY", EmitDefaultValue = false)]
        public int BottomRightY { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OCRRect {\n");
            sb.Append("  TopLeftX: ").Append(TopLeftX).Append("\n");
            sb.Append("  TopLeftY: ").Append(TopLeftY).Append("\n");
            sb.Append("  BottomRightX: ").Append(BottomRightX).Append("\n");
            sb.Append("  BottomRightY: ").Append(BottomRightY).Append("\n");
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
            return this.Equals(input as OCRRect);
        }

        /// <summary>
        /// Returns true if OCRRect instances are equal
        /// </summary>
        /// <param name="input">Instance of OCRRect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OCRRect input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TopLeftX == input.TopLeftX ||
                    this.TopLeftX.Equals(input.TopLeftX)
                ) && 
                (
                    this.TopLeftY == input.TopLeftY ||
                    this.TopLeftY.Equals(input.TopLeftY)
                ) && 
                (
                    this.BottomRightX == input.BottomRightX ||
                    this.BottomRightX.Equals(input.BottomRightX)
                ) && 
                (
                    this.BottomRightY == input.BottomRightY ||
                    this.BottomRightY.Equals(input.BottomRightY)
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
                hashCode = (hashCode * 59) + this.TopLeftX.GetHashCode();
                hashCode = (hashCode * 59) + this.TopLeftY.GetHashCode();
                hashCode = (hashCode * 59) + this.BottomRightX.GetHashCode();
                hashCode = (hashCode * 59) + this.BottomRightY.GetHashCode();
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
