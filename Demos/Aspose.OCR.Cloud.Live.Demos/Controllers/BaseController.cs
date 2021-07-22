using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Xml;

namespace Aspose.OCR.Cloud.Live.Demos.Controllers
{
    public abstract class BaseController : Controller
    {
        public abstract string Product { get; }

        public string CacheResourcesKey => nameof(CacheResourcesKey);

        public IMemoryCache Cache { get; }

        public BaseController(IMemoryCache cache)
        {
            Cache = cache;
        }

        private static void LoadDocumentToDictionary(string filePath, Dictionary<string, string> resources)
        {
            var document = new XmlDocument();
            document.Load(filePath);

            XmlNodeList nodes = document.SelectNodes("resources/res");

            foreach (XmlNode n in nodes)
            {
                string value = n.Attributes["name"].Value;
                resources[value] = n.InnerText;
            }
        }

        public Dictionary<string, string> Resources
        {
            get
            {
                Dictionary<string, string> _resources = null;

                string key = CacheResourcesKey;

                bool ret = Cache.TryGetValue(key, out _resources);

                if (!ret)
                {
                    var resourceFilePath = Startup.WebHostEnvironment.ContentRootPath + "\\App_Data\\resources_EN.xml";

                    _resources = new Dictionary<string, string>();

                    LoadDocumentToDictionary(resourceFilePath, _resources);

                    Cache.Set(key, _resources);

                }

                return _resources;
            }

        }

    }

}
