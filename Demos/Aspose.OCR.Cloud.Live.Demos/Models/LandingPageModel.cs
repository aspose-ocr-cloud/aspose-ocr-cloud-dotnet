using Aspose.OCR.Cloud.Live.Demos.Controllers;
using System.Collections.Generic;

namespace Aspose.OCR.Cloud.Live.Demos.Models
{
    public class LandingPageModel
    {
        public BaseController Controller;
        public Dictionary<string, string> Resources { get; set; }

        public LandingPageModel(BaseController controller)
        {
            Controller = controller;
            Resources = controller.Resources;
        }
    }
}
