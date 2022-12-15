using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.OCR.Cloud.SDK.Test.Api
{
    internal static class Config
    {
        private static string _targetURI = "https://api.aspose.cloud/v5.0/ocr";

        private static string _targetAuthURI = @"https://api.aspose.cloud/connect/token";

        private static string _targetClientId = "";

        private static string _targetClientSecret = "";


        private static bool _simpleInstanceCreation = true;


        public static string TargetURI 
        {
            get 
            {
                return _targetURI; 
            }
        }

        public static string TargetAuthURI 
        {
            get 
            {
                return _targetAuthURI; 
            }
        }

        public static string TargetClientId 
        {
            get 
            {
                return _targetClientId; 
            }
        }

        public static string TargetClientSecret 
        {
            get 
            {
                return _targetClientSecret; 
            }
        }

        public static bool SimpleInstanceCreation
        {
            get { return _simpleInstanceCreation; }
        }
    }
}
