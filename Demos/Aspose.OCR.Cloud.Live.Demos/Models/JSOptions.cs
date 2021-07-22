using System.Collections.Generic;

namespace Aspose.OCR.Cloud.Live.Demos.Models
{
    public class JSOptions
    {
        private readonly ViewModel Parent;
        private Dictionary<string, string> Resources => Parent.Resources;

        string GetUIBasePath()
        {
            var request = Parent.Controller.Request;
            string strBasePath = $"{request.Scheme}://{request.Host}/";
            return strBasePath;
        }

        public string UIBasePath => GetUIBasePath();

        public int MaximumUploadFiles => Parent.MaximumUploadFiles;

        public string FileWrongTypeMessage { get; }

        public string FileSelectMessage => Resources["FileSelectMessage"];
        public string FileAmountMessage => Resources["FileAmountMessageOne"];

        public bool UseSorting => Parent.UseSorting;

        #region FileDrop
        public bool Multiple => MaximumUploadFiles > 1;
        public string DropFilesPrompt => Resources["DropOrUploadFile"];
        public string Accept => Parent.ExtensionsString.Replace("|.", ",.");
        #endregion

        public IEnumerable<string> UploadOptions => Parent.ExtensionsString.Replace(".", "").ToUpper().Split('|');

        public JSOptions(ViewModel model)
        {
            Parent = model;
            FileWrongTypeMessage = Resources["FileWrongTypeMessage"];
        }

        public override string ToString()
        {
            string strJson = System.Text.Json.JsonSerializer.Serialize(this);
            return strJson;
        }
    }
}
