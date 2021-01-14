using System;
using System.Web;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace Aspose.OCR.Cloud.Live.Demos.UI.Config
{
	/// <summary>
	/// Wrapper class for Aspose.OCR Cloud Tools context access to Pages and controls
	/// </summary>
	public class AsposeOCRCloudContext : Context
	{
		/// <summary>
		/// The context data is directly picked up from the Application Thread's data slots, this is required to share the context between
		/// independent threads working for this application, e.g. AsyncHttpRequestHandlers and other assemblies as well, this will also 
		/// eliminate the need for extra copies and object cloning b/w assemblies
		/// </summary>
		/// <param name="hc"></param>
		internal AsposeOCRCloudContext(HttpContext hc) : base(hc) {
			string rfsn = Configuration.ResourceFileSessionName + "ContextSlot";
			LocalDataStoreSlot ldss = Thread.GetNamedDataSlot(rfsn);
			Thread.SetData(ldss, hc); 
		}

		private static AsposeOCRCloudContext atc;
		/// <summary>
		///  Use for internal syncing of the context
		/// </summary>
		internal static AsposeOCRCloudContext atcc { set { atc = value; } }
		internal static AsposeOCRCloudContext Current
		{
			get { return atc; }
		}

		internal new Dictionary<string, string> Resources
		{
			get { return base.Resources; }
		}
	}
}
