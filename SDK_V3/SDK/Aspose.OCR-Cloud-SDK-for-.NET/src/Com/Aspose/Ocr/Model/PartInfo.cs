using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Aspose.Ocr.Model {

  /// <summary>
  /// Represents information about part of the text.
  /// </summary>
  public class PartInfo {
    /// <summary>
    /// Gets or sets recognized text.
    /// </summary>
    /// <value>Gets or sets recognized text.</value>
    public string Text { get; set; }

    /// <summary>
    /// Gets or sets box around recognized text.
    /// </summary>
    /// <value>Gets or sets box around recognized text.</value>
    public Box Box { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartInfo {\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Box: ").Append(Box).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }


}
}
