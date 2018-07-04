using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Aspose.Ocr.Model {

  /// <summary>
  /// 
  /// </summary>
  public class Point : ValueType {
    /// <summary>
    /// Gets or Sets IsEmpty
    /// </summary>
    public bool? IsEmpty { get; set; }

    /// <summary>
    /// Gets or Sets X
    /// </summary>
    public int? X { get; set; }

    /// <summary>
    /// Gets or Sets Y
    /// </summary>
    public int? Y { get; set; }

    /// <summary>
    /// Gets or Sets Empty
    /// </summary>
    public Point Empty { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Point {\n");
      sb.Append("  IsEmpty: ").Append(IsEmpty).Append("\n");
      sb.Append("  X: ").Append(X).Append("\n");
      sb.Append("  Y: ").Append(Y).Append("\n");
      sb.Append("  Empty: ").Append(Empty).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }


}
}
