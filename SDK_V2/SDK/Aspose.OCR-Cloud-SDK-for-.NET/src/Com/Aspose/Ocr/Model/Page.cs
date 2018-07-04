using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Aspose.Ocr.Model {

  /// <summary>
  /// Represents separate page of document.
  /// </summary>
  public class Page {
    /// <summary>
    /// Entire test fo current page.
    /// </summary>
    /// <value>Entire test fo current page.</value>
    public string PageText { get; set; }

    /// <summary>
    /// List of parts with text in image.
    /// </summary>
    /// <value>List of parts with text in image.</value>
    public List<PartInfo> Parts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Page {\n");
      sb.Append("  PageText: ").Append(PageText).Append("\n");
      sb.Append("  Parts: ").Append(Parts).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }


}
}
