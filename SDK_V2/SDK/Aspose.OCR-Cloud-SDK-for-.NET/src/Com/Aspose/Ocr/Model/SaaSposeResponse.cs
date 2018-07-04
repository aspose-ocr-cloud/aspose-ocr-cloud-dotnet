using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Aspose.Ocr.Model {

  /// <summary>
  /// The basic SaaSposeResponse response class kept from the old Aspose for Cloud Platform. We keep this base class and use it because most probably users are already using it to get API responses. The plan in future is to get rid of this name, but who knows when ?!
  /// </summary>
  public class SaaSposeResponse {
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SaaSposeResponse {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }


}
}
