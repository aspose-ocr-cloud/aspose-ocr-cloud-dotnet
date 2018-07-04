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
  public class ServerStat {
    /// <summary>
    /// Server's absolute time statistics
    /// </summary>
    /// <value>Server's absolute time statistics</value>
    public Dictionary<string, DateTime?> ServerTime { get; set; }

    /// <summary>
    /// Server's time diffs
    /// </summary>
    /// <value>Server's time diffs</value>
    public Dictionary<string, string> ServerTimespans { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerStat {\n");
      sb.Append("  ServerTime: ").Append(ServerTime).Append("\n");
      sb.Append("  ServerTimespans: ").Append(ServerTimespans).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }


}
}
