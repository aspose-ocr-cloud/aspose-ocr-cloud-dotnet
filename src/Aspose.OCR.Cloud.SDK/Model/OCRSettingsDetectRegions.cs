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
    /// OCR Process setting for Image recognition
    /// </summary>
    [DataContract(Name = "OCRSettingsDetectRegions")]
    public partial class OCRSettingsDetectRegions : IEquatable<OCRSettingsDetectRegions>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DsrConfidence
        /// </summary>
        [DataMember(Name = "dsrConfidence", EmitDefaultValue = false)]
        public DsrConfidence? DsrConfidence { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public Language? Language { get; set; }

        /// <summary>
        /// Gets or Sets DsrMode
        /// </summary>
        [DataMember(Name = "dsrMode", EmitDefaultValue = false)]
        public DsrMode? DsrMode { get; set; }

        /// <summary>
        /// Gets or Sets ResultType
        /// </summary>
        [DataMember(Name = "resultType", EmitDefaultValue = false)]
        public ResultType? ResultType { get; set; }

        /// <summary>
        /// Gets or Sets ResultTypeTable
        /// </summary>
        [DataMember(Name = "resultTypeTable", EmitDefaultValue = false)]
        public ResultTypeTable? ResultTypeTable { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OCRSettingsDetectRegions" /> class.
        /// </summary>
        /// <param name="makeSkewCorrect">Option to enable skew correction algorithm. True by default (default to true).</param>
        /// <param name="makeContrastCorrection">Option to enable image contrast correction algorithm. True by default (default to true).</param>
        /// <param name="makeUpsampling">Option to enable image up-sampling algorithm to improve quality. True by default (default to false).</param>
        /// <param name="dsrConfidence">dsrConfidence.</param>
        /// <param name="language">language.</param>
        /// <param name="makeSpellCheck">Option to enable spell checking and correction algorithm. False by default (default to false).</param>
        /// <param name="makeBinarization">Option to enable image binarization algorithm. False by default (default to true).</param>
        /// <param name="dsrMode">dsrMode.</param>
        /// <param name="resultType">resultType.</param>
        /// <param name="resultTypeTable">resultTypeTable.</param>
        /// <param name="regions">regions.</param>
        public OCRSettingsDetectRegions(bool makeSkewCorrect = true, bool makeContrastCorrection = true, bool makeUpsampling = false, DsrConfidence? dsrConfidence = default(DsrConfidence?), Language? language = default(Language?), bool makeSpellCheck = false, bool makeBinarization = true, DsrMode? dsrMode = default(DsrMode?), ResultType? resultType = default(ResultType?), ResultTypeTable? resultTypeTable = default(ResultTypeTable?), List<OCRRegion> regions = default(List<OCRRegion>))
        {
            this.MakeSkewCorrect = makeSkewCorrect;
            this.MakeContrastCorrection = makeContrastCorrection;
            this.MakeUpsampling = makeUpsampling;
            this.DsrConfidence = dsrConfidence;
            this.Language = language;
            this.MakeSpellCheck = makeSpellCheck;
            this.MakeBinarization = makeBinarization;
            this.DsrMode = dsrMode;
            this.ResultType = resultType;
            this.ResultTypeTable = resultTypeTable;
            this.Regions = regions;
        }

        /// <summary>
        /// Option to enable skew correction algorithm. True by default
        /// </summary>
        /// <value>Option to enable skew correction algorithm. True by default</value>
        [DataMember(Name = "makeSkewCorrect", EmitDefaultValue = true)]
        public bool MakeSkewCorrect { get; set; }

        /// <summary>
        /// Option to enable image contrast correction algorithm. True by default
        /// </summary>
        /// <value>Option to enable image contrast correction algorithm. True by default</value>
        [DataMember(Name = "makeContrastCorrection", EmitDefaultValue = true)]
        public bool MakeContrastCorrection { get; set; }

        /// <summary>
        /// Option to enable image up-sampling algorithm to improve quality. True by default
        /// </summary>
        /// <value>Option to enable image up-sampling algorithm to improve quality. True by default</value>
        [DataMember(Name = "makeUpsampling", EmitDefaultValue = true)]
        public bool MakeUpsampling { get; set; }

        /// <summary>
        /// Option to enable spell checking and correction algorithm. False by default
        /// </summary>
        /// <value>Option to enable spell checking and correction algorithm. False by default</value>
        [DataMember(Name = "makeSpellCheck", EmitDefaultValue = true)]
        public bool MakeSpellCheck { get; set; }

        /// <summary>
        /// Option to enable image binarization algorithm. False by default
        /// </summary>
        /// <value>Option to enable image binarization algorithm. False by default</value>
        [DataMember(Name = "makeBinarization", EmitDefaultValue = true)]
        public bool MakeBinarization { get; set; }

        /// <summary>
        /// Gets or Sets Regions
        /// </summary>
        [DataMember(Name = "regions", EmitDefaultValue = false)]
        public List<OCRRegion> Regions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OCRSettingsDetectRegions {\n");
            sb.Append("  MakeSkewCorrect: ").Append(MakeSkewCorrect).Append("\n");
            sb.Append("  MakeContrastCorrection: ").Append(MakeContrastCorrection).Append("\n");
            sb.Append("  MakeUpsampling: ").Append(MakeUpsampling).Append("\n");
            sb.Append("  DsrConfidence: ").Append(DsrConfidence).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  MakeSpellCheck: ").Append(MakeSpellCheck).Append("\n");
            sb.Append("  MakeBinarization: ").Append(MakeBinarization).Append("\n");
            sb.Append("  DsrMode: ").Append(DsrMode).Append("\n");
            sb.Append("  ResultType: ").Append(ResultType).Append("\n");
            sb.Append("  ResultTypeTable: ").Append(ResultTypeTable).Append("\n");
            sb.Append("  Regions: ").Append(Regions).Append("\n");
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
            return this.Equals(input as OCRSettingsDetectRegions);
        }

        /// <summary>
        /// Returns true if OCRSettingsDetectRegions instances are equal
        /// </summary>
        /// <param name="input">Instance of OCRSettingsDetectRegions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OCRSettingsDetectRegions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MakeSkewCorrect == input.MakeSkewCorrect ||
                    this.MakeSkewCorrect.Equals(input.MakeSkewCorrect)
                ) && 
                (
                    this.MakeContrastCorrection == input.MakeContrastCorrection ||
                    this.MakeContrastCorrection.Equals(input.MakeContrastCorrection)
                ) && 
                (
                    this.MakeUpsampling == input.MakeUpsampling ||
                    this.MakeUpsampling.Equals(input.MakeUpsampling)
                ) && 
                (
                    this.DsrConfidence == input.DsrConfidence ||
                    this.DsrConfidence.Equals(input.DsrConfidence)
                ) && 
                (
                    this.Language == input.Language ||
                    this.Language.Equals(input.Language)
                ) && 
                (
                    this.MakeSpellCheck == input.MakeSpellCheck ||
                    this.MakeSpellCheck.Equals(input.MakeSpellCheck)
                ) && 
                (
                    this.MakeBinarization == input.MakeBinarization ||
                    this.MakeBinarization.Equals(input.MakeBinarization)
                ) && 
                (
                    this.DsrMode == input.DsrMode ||
                    this.DsrMode.Equals(input.DsrMode)
                ) && 
                (
                    this.ResultType == input.ResultType ||
                    this.ResultType.Equals(input.ResultType)
                ) && 
                (
                    this.ResultTypeTable == input.ResultTypeTable ||
                    this.ResultTypeTable.Equals(input.ResultTypeTable)
                ) && 
                (
                    this.Regions == input.Regions ||
                    this.Regions != null &&
                    input.Regions != null &&
                    this.Regions.SequenceEqual(input.Regions)
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
                hashCode = (hashCode * 59) + this.MakeSkewCorrect.GetHashCode();
                hashCode = (hashCode * 59) + this.MakeContrastCorrection.GetHashCode();
                hashCode = (hashCode * 59) + this.MakeUpsampling.GetHashCode();
                hashCode = (hashCode * 59) + this.DsrConfidence.GetHashCode();
                hashCode = (hashCode * 59) + this.Language.GetHashCode();
                hashCode = (hashCode * 59) + this.MakeSpellCheck.GetHashCode();
                hashCode = (hashCode * 59) + this.MakeBinarization.GetHashCode();
                hashCode = (hashCode * 59) + this.DsrMode.GetHashCode();
                hashCode = (hashCode * 59) + this.ResultType.GetHashCode();
                hashCode = (hashCode * 59) + this.ResultTypeTable.GetHashCode();
                if (this.Regions != null)
                {
                    hashCode = (hashCode * 59) + this.Regions.GetHashCode();
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
