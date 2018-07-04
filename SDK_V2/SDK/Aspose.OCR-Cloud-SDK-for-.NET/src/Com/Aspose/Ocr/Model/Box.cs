using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Aspose.Ocr.Model {

  /// <summary>
  /// Represents rectangle box around part of text.             
  /// </summary>
  public class Box {
    /// <summary>
    /// Gets or sets location of the box.
    /// </summary>
    /// <value>Gets or sets location of the box.</value>
    public Point Location { get; set; }

    /// <summary>
    /// Gets or sets size of the box.
    /// </summary>
    /// <value>Gets or sets size of the box.</value>
    public Size Size { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Box {\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }


}
}
