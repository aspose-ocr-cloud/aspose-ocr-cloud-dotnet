using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Aspose.Ocr.Model {

  /// <summary>
  /// Represents information about response after OCR.
  /// </summary>
  public class OCRResponse : SaaSposeResponse {
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets text after response.
    /// </summary>
    /// <value>Gets or sets text after response.</value>
    public string Text { get; set; }

    /// <summary>
    /// Gets or sets informaton about every part of the text.
    /// </summary>
    /// <value>Gets or sets informaton about every part of the text.</value>
    public PartsInfo PartsInfo { get; set; }

    /// <summary>
    /// Gets or sets informaton about every page with text.
    /// </summary>
    /// <value>Gets or sets informaton about every page with text.</value>
    public PagesInfo PagesInfo { get; set; }

    /// <summary>
    /// Gets informaton about server statistics
    /// </summary>
    /// <value>Gets informaton about server statistics</value>
    public ServerStat ServerStat { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OCRResponse {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  PartsInfo: ").Append(PartsInfo).Append("\n");
      sb.Append("  PagesInfo: ").Append(PagesInfo).Append("\n");
      sb.Append("  ServerStat: ").Append(ServerStat).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }


}
}
