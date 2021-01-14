using Aspose.OCR.Cloud.Live.Demos.UI.Models;
using Aspose.OCR.Cloud.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using Aspose.Storage.Cloud.Sdk.Api;
using Aspose.Storage.Cloud.Sdk.Model.Requests;
using Aspose.OCR.Cloud.Live.Demos.UI;

namespace Aspose.OCR.Cloud.Live.Demos.UI.Controllers
{
	/// <summary>
	/// Common  API controller.
	/// </summary>

	public  class CommonController : BaseController
	{
		public override string Product => (string)RouteData.Values["product"];
		StorageApi storageApi = new StorageApi(Config.Configuration.AppKey, Config.Configuration.AppSID);
		/// <summary>
		/// Sends back specified file from specified folder inside OutputDirectory.
		/// </summary>
		/// <param name="folder">Folder inside OutputDirectory.</param>
		/// <param name="file">File.</param>
		/// <returns>HTTP response with file.</returns>


		public FileResult DownloadFile(string file)
		{
			GetDownloadRequest getDownloadRequest = new GetDownloadRequest(file);
			return File(storageApi.GetDownload(getDownloadRequest), "application/octet-stream", file);
		}
		
	}
}
