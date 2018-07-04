using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Aspose.Ocr.Model {

  /// <summary>
  /// Represents information about pages in document.
  /// </summary>
  public class PagesInfo {
    /// <summary>
    /// List of parts with text in image.
    /// </summary>
    /// <value>List of parts with text in image.</value>
    public List<Page> Pages { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PagesInfo {\n");
      sb.Append("  Pages: ").Append(Pages).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }


}
}
