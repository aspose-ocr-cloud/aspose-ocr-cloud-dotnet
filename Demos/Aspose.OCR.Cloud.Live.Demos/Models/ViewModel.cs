using Aspose.OCR.Cloud.Live.Demos.Controllers;
using System.Collections.Generic;

namespace Aspose.OCR.Cloud.Live.Demos.Models
{
    public class ViewModel
    {
        public int MaximumUploadFiles { get; set; }

        public string Product { get; set; }

        public BaseController Controller;
        public Dictionary<string, string> Resources { get; set; }

        public string ProductAppName { get; set; }

        public string PageProductTitle => Resources["Aspose" + TitleCase(Product)];

        protected string TitleCase(string value) => new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(value);

        public string AppName { get; set; }

        public string AppUrl { get; set; }

        public string AnotherFileText { get; set; }

        public string UploadButtonText { get; set; }

        public string SuccessMessage { get; set; }

        public List<string> AppFeatures { get; set; }

        public string Title { get; set; }

        public string TitleSub { get; set; }

        public string PageTitle
        {
            get => Controller.ViewBag.PageTitle;
            set => Controller.ViewBag.PageTitle = value;
        }

        public string MetaDescription
        {
            get => Controller.ViewBag.MetaDescription;
            set => Controller.ViewBag.MetaDescription = value;
        }

        public string MetaKeywords
        {
            get => Controller.ViewBag.MetaKeywords;
            set => Controller.ViewBag.MetaKeywords = value;
        }

        public bool UploadAndRedirect { get; set; }

        public bool UseSorting { get; set; }

        public string ExtensionsString { get; set; }

        private bool _saveAsComponent;
        public bool SaveAsComponent
        {
            get => _saveAsComponent;

            set
            {
                _saveAsComponent = value;
                Controller.ViewBag.SaveAsComponent = value;

                if (_saveAsComponent)
                {
                    var sokey1 = $"{Product}{AppName}SaveAsOptions";

                    if (Resources.ContainsKey(sokey1))
                        SaveAsOptions = Resources[sokey1].Split(',');
                }
            }
        }

        public string[] SaveAsOptions { get; set; }

        public string SaveAsOptionsList
        {
            get
            {
                string list = "";

                foreach (var extension in SaveAsOptions)
                {
                    if (list == "")
                    {
                        list = extension.ToUpper();
                    }
                    else
                    {
                        list = list + ", " + extension.ToUpper();
                    }
                }

                return list;
            }
        }

        public bool IsCanonical;

        public HowToModel HowToModel { get; set; }
        public bool HowTo => HowToModel != null;

        public ViewModel(BaseController controller, string app)
        {
            Controller = controller;
            Resources = controller.Resources;
            AppName = app;
            Product = controller.Product;
            string url = $"{controller.Request.Scheme}://{controller.Request.Host}{controller.Request.Path}";

            AppUrl = url.Substring(0, (url.IndexOf("?") > 0 ? url.IndexOf("?") : url.Length));
            ProductAppName = Product + app;

            UploadButtonText = GetFromResources(ProductAppName + "Button", app + "Button");
            SuccessMessage = GetFromResources(app + "SuccessMessage");
            AnotherFileText = GetFromResources(app + "AnotherFile");
            IsCanonical = true;
            HowToModel = new HowToModel(this);
            SetTitles();

            UseSorting = true;
            SaveAsComponent = false;
            SetExtensionsString();
        }

        private string GetFromResources(string key, string defaultKey = null)
        {
            if (Resources.ContainsKey(key))
                return Resources[key];

            if (!string.IsNullOrEmpty(defaultKey) && Resources.ContainsKey(defaultKey))
                return Resources[defaultKey];

            return "";
        }

        private void SetTitles()
        {
            PageTitle = Resources[ProductAppName + "PageTitle"];
            MetaDescription = Resources[ProductAppName + "MetaDescription"];
            MetaKeywords = "";
            Title = Resources[ProductAppName + "Title"];
            TitleSub = Resources[ProductAppName + "SubTitle"];
        }

        private void SetAppFeatures(string app)
        {
            AppFeatures = new List<string>();
        }

        private void SetExtensionsString()
        {
            var key = $"{Product}ValidationExpression";
            ExtensionsString = Resources[key];
        }

        public string JSOptions => new JSOptions(this).ToString();
    }
}
