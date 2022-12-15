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
    /// PostUpsamplingFileRequest
    /// </summary>
    [DataContract(Name = "PostUpsamplingFile_request")]
    public partial class PostUpsamplingFileRequest : IEquatable<PostUpsamplingFileRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostUpsamplingFileRequest" /> class.
        /// </summary>
        /// <param name="file">file.</param>
        public PostUpsamplingFileRequest(System.IO.Stream file = default(System.IO.Stream))
        {
            this.File = file;
        }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false)]
        public System.IO.Stream File { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostUpsamplingFileRequest {\n");
            sb.Append("  File: ").Append(File).Append("\n");
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
            return this.Equals(input as PostUpsamplingFileRequest);
        }

        /// <summary>
        /// Returns true if PostUpsamplingFileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostUpsamplingFileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostUpsamplingFileRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
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
                if (this.File != null)
                {
                    hashCode = (hashCode * 59) + this.File.GetHashCode();
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
