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
    /// Response with Recognition result for specific task ID
    /// </summary>
    [DataContract(Name = "TTSResponse")]
    public partial class TTSResponse : IEquatable<TTSResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ResponseStatusCode
        /// </summary>
        [DataMember(Name = "responseStatusCode", EmitDefaultValue = false)]
        public ResponseStatusCode? ResponseStatusCode { get; set; }

        /// <summary>
        /// Gets or Sets TaskStatus
        /// </summary>
        [DataMember(Name = "taskStatus", EmitDefaultValue = false)]
        public TTSTaskStatus? TaskStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TTSResponse" /> class.
        /// </summary>
        /// <param name="id">The specific Task ID that result was made for.</param>
        /// <param name="responseStatusCode">responseStatusCode.</param>
        /// <param name="taskStatus">taskStatus.</param>
        /// <param name="error">error.</param>
        public TTSResponse(string id = default(string), ResponseStatusCode? responseStatusCode = default(ResponseStatusCode?), TTSTaskStatus? taskStatus = default(TTSTaskStatus?), TTSError error = default(TTSError))
        {
            this.Id = id;
            this.ResponseStatusCode = responseStatusCode;
            this.TaskStatus = taskStatus;
            this.Error = error;
        }

        /// <summary>
        /// The specific Task ID that result was made for
        /// </summary>
        /// <value>The specific Task ID that result was made for</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// List of results - Especially Text or PDF files
        /// </summary>
        /// <value>List of results - Especially Text or PDF files</value>
        [DataMember(Name = "results", EmitDefaultValue = true)]
        public List<TTSResult> Results { get; private set; }

        /// <summary>
        /// Returns false as Results should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResults()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public TTSError Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TTSResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ResponseStatusCode: ").Append(ResponseStatusCode).Append("\n");
            sb.Append("  TaskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as TTSResponse);
        }

        /// <summary>
        /// Returns true if TTSResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TTSResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TTSResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ResponseStatusCode == input.ResponseStatusCode ||
                    this.ResponseStatusCode.Equals(input.ResponseStatusCode)
                ) && 
                (
                    this.TaskStatus == input.TaskStatus ||
                    this.TaskStatus.Equals(input.TaskStatus)
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResponseStatusCode.GetHashCode();
                hashCode = (hashCode * 59) + this.TaskStatus.GetHashCode();
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
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