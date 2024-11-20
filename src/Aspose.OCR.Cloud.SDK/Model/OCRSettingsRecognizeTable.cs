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
    /// OCR Process setting for Table image recognition
    /// </summary>
    [DataContract(Name = "OCRSettingsRecognizeTable")]
    public partial class OCRSettingsRecognizeTable : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public Language? Language { get; set; }

        /// <summary>
        /// Gets or Sets ResultTypeTable
        /// </summary>
        [DataMember(Name = "resultTypeTable", EmitDefaultValue = false)]
        public ResultTypeTable? ResultTypeTable { get; set; }

        /// <summary>
        /// Gets or Sets DsrMode
        /// </summary>
        [DataMember(Name = "dsrMode", EmitDefaultValue = false)]
        public DsrMode? DsrMode { get; set; }

        /// <summary>
        /// Gets or Sets DsrConfidence
        /// </summary>
        [DataMember(Name = "dsrConfidence", EmitDefaultValue = false)]
        public DsrConfidence? DsrConfidence { get; set; }

        /// <summary>
        /// Gets or Sets ResultType
        /// </summary>
        [DataMember(Name = "resultType", EmitDefaultValue = false)]
        public ResultType? ResultType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OCRSettingsRecognizeTable" /> class.
        /// </summary>
        /// <param name="language">language.</param>
        /// <param name="makeSkewCorrect">Option to enable skew correction algorithm. True by default (default to true).</param>
        /// <param name="makeSpellCheck">Option to enable spell checking and correction algorithm. False by default (default to false).</param>
        /// <param name="makeContrastCorrection">Option to enable image contrast correction algorithm. True by default (default to false).</param>
        /// <param name="resultTypeTable">resultTypeTable.</param>
        /// <param name="rotate">Rotate image&gt;.</param>
        /// <param name="makeBinarization">Option to enable image binarization algorithm. False by default (default to true).</param>
        /// <param name="makeUpsampling">Option to enable image up-sampling algorithm to improve quality. True by default (default to false).</param>
        /// <param name="dsrMode">dsrMode.</param>
        /// <param name="dsrConfidence">dsrConfidence.</param>
        /// <param name="resultType">resultType.</param>
        /// <param name="regions">Region on image to recognize in specific format. Aspose.Ocr.Cloud.Public.OCRRegion.</param>
        public OCRSettingsRecognizeTable(Language? language = default(Language?), bool makeSkewCorrect = true, bool makeSpellCheck = false, bool makeContrastCorrection = false, ResultTypeTable? resultTypeTable = default(ResultTypeTable?), int rotate = default(int), bool makeBinarization = true, bool makeUpsampling = false, DsrMode? dsrMode = default(DsrMode?), DsrConfidence? dsrConfidence = default(DsrConfidence?), ResultType? resultType = default(ResultType?), List<OCRRegion> regions = default(List<OCRRegion>))
        {
            this.Language = language;
            this.MakeSkewCorrect = makeSkewCorrect;
            this.MakeSpellCheck = makeSpellCheck;
            this.MakeContrastCorrection = makeContrastCorrection;
            this.ResultTypeTable = resultTypeTable;
            this.Rotate = rotate;
            this.MakeBinarization = makeBinarization;
            this.MakeUpsampling = makeUpsampling;
            this.DsrMode = dsrMode;
            this.DsrConfidence = dsrConfidence;
            this.ResultType = resultType;
            this.Regions = regions;
        }

        /// <summary>
        /// Option to enable skew correction algorithm. True by default
        /// </summary>
        /// <value>Option to enable skew correction algorithm. True by default</value>
        [DataMember(Name = "makeSkewCorrect", EmitDefaultValue = true)]
        public bool MakeSkewCorrect { get; set; }

        /// <summary>
        /// Option to enable spell checking and correction algorithm. False by default
        /// </summary>
        /// <value>Option to enable spell checking and correction algorithm. False by default</value>
        [DataMember(Name = "makeSpellCheck", EmitDefaultValue = true)]
        public bool MakeSpellCheck { get; set; }

        /// <summary>
        /// Option to enable image contrast correction algorithm. True by default
        /// </summary>
        /// <value>Option to enable image contrast correction algorithm. True by default</value>
        [DataMember(Name = "makeContrastCorrection", EmitDefaultValue = true)]
        [Obsolete]
        public bool MakeContrastCorrection { get; set; }

        /// <summary>
        /// Rotate image&gt;
        /// </summary>
        /// <value>Rotate image&gt;</value>
        [DataMember(Name = "Rotate", EmitDefaultValue = false)]
        public int Rotate { get; set; }

        /// <summary>
        /// Option to enable image binarization algorithm. False by default
        /// </summary>
        /// <value>Option to enable image binarization algorithm. False by default</value>
        [DataMember(Name = "makeBinarization", EmitDefaultValue = true)]
        public bool MakeBinarization { get; set; }

        /// <summary>
        /// Option to enable image up-sampling algorithm to improve quality. True by default
        /// </summary>
        /// <value>Option to enable image up-sampling algorithm to improve quality. True by default</value>
        [DataMember(Name = "makeUpsampling", EmitDefaultValue = true)]
        public bool MakeUpsampling { get; set; }

        /// <summary>
        /// Region on image to recognize in specific format. Aspose.Ocr.Cloud.Public.OCRRegion
        /// </summary>
        /// <value>Region on image to recognize in specific format. Aspose.Ocr.Cloud.Public.OCRRegion</value>
        [DataMember(Name = "regions", EmitDefaultValue = true)]
        public List<OCRRegion> Regions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OCRSettingsRecognizeTable {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  MakeSkewCorrect: ").Append(MakeSkewCorrect).Append("\n");
            sb.Append("  MakeSpellCheck: ").Append(MakeSpellCheck).Append("\n");
            sb.Append("  MakeContrastCorrection: ").Append(MakeContrastCorrection).Append("\n");
            sb.Append("  ResultTypeTable: ").Append(ResultTypeTable).Append("\n");
            sb.Append("  Rotate: ").Append(Rotate).Append("\n");
            sb.Append("  MakeBinarization: ").Append(MakeBinarization).Append("\n");
            sb.Append("  MakeUpsampling: ").Append(MakeUpsampling).Append("\n");
            sb.Append("  DsrMode: ").Append(DsrMode).Append("\n");
            sb.Append("  DsrConfidence: ").Append(DsrConfidence).Append("\n");
            sb.Append("  ResultType: ").Append(ResultType).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
