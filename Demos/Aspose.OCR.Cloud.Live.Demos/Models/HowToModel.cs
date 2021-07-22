using System.Collections.Generic;

namespace Aspose.OCR.Cloud.Live.Demos.Models
{
    public class HowToModel
    {
        public ViewModel VMParent;
        public string AppName => VMParent.AppName;
        public string Title { get; set; }
        public List<string> List { get; set; }
        public HowToModel(ViewModel parent)
        {
            VMParent = parent;

            var title = VMParent.Resources[$"Howto{AppName}Title"];
            var titleEnd = VMParent.PageProductTitle + " " + AppName;
            Title = string.Format(title, "", titleEnd);

            List = new List<string>();
            var hw = "Howto" + VMParent.AppName + "Feature";
            var i = 1;

            while (VMParent.Resources.ContainsKey(hw + i))
            {
                List.Add(VMParent.Resources[hw + i]);
                i++;
            }
        }
    }
}
