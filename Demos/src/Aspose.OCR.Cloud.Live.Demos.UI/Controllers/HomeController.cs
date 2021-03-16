using Aspose.OCR.Cloud.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.OCR.Cloud.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "Free Online Image To Text Converter - Online OCR Software";
			ViewBag.MetaDescription = "Convert image to text with free online OCR service. Convert images of popular formats like JPG, BMP, TIFF, GIF, PNG to plain editable text.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
