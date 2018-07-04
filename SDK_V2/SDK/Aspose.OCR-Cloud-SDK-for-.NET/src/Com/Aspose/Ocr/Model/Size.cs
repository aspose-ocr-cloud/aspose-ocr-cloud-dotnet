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
  public class Size : ValueType {
    /// <summary>
    /// Gets or Sets IsEmpty
    /// </summary>
    public bool? IsEmpty { get; set; }

    /// <summary>
    /// Gets or Sets Width
    /// </summary>
    public int? Width { get; set; }

    /// <summary>
    /// Gets or Sets Height
    /// </summary>
    public int? Height { get; set; }

    /// <summary>
    /// Gets or Sets Empty
    /// </summary>
    public Size Empty { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Size {\n");
      sb.Append("  IsEmpty: ").Append(IsEmpty).Append("\n");
      sb.Append("  Width: ").Append(Width).Append("\n");
      sb.Append("  Height: ").Append(Height).Append("\n");
      sb.Append("  Empty: ").Append(Empty).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }


}
}
