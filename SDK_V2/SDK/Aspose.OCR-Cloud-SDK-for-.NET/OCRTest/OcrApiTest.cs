using Com.Aspose.Ocr.Api;
using Com.Aspose.Ocr.Model;
using Com.Aspose.Storage.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OCRTest
{
    
    
    /// <summary>
    ///This is a test class for TestOcrApi and is intended
    ///to contain all TestOcrApi Unit Tests
    ///</summary>
    [TestClass()]
    public class TestOcrApi
    {
        JObject Config;
        private string APIKEY => Config["api_key"].ToString();
        private string APPSID => Config["api_sid"].ToString();

        private string BASEPATH => Config["base_path"].ToString();

        private string DataFolder = "";

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        
        [TestInitialize]
        public void Start()
        {
            DirectoryInfo current = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (null != current && current.GetFiles("test_config.json").Length == 0)
                current = current.Parent;
            if (null == current) return;

            Config = JObject.Parse(System.IO.File.ReadAllText(Path.Combine(current.FullName, "test_config.json")));
            DataFolder = Path.Combine(current.FullName, "Data");
        }

        
        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion



        /// <summary>
        ///A test for GetRecognizeDocument
        ///</summary>
        [TestMethod()]
        public void TestGetRecognizeDocument()
        {
            OcrApi target = new OcrApi(APIKEY, APPSID, BASEPATH);
            StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

            string name = "Dr._Jekyll_and_Mr._Hyde_Text.jpg";
            string language =  "english";
            int? rectX = null;
            int? rectY = null;
            int? rectWidth = null;
            int? rectHeight = null;
            bool? doSpellCorrection = null;
            bool? skewCorrection = null;
            string storage =  null;
            string folder =  null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Path.Combine(DataFolder, name)));
            
            Com.Aspose.Ocr.Model.OCRResponse actual;
            actual = target.OcrGetRecognizeDocument(name, language, rectX, rectY, rectWidth, rectHeight, doSpellCorrection, skewCorrection, storage, folder);
            
            Assert.AreEqual("OK", actual.Status);
            Assert.IsInstanceOfType(new OCRResponse(), actual.GetType()); 
        }

        /// <summary>
        ///A test for GetRecognizeDocumentCloud
        ///</summary>
        [TestMethod()]
        public void V2_TestGetRecognizeDocument()
        {
            OcrV2Api target = new OcrV2Api(APIKEY, APPSID, BASEPATH);
            StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

            string name = "Dr._Jekyll_and_Mr._Hyde_Text.jpg";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, "", "", System.IO.File.ReadAllBytes(Path.Combine(DataFolder, name)));

            Com.Aspose.Ocr.Model.OCRResponse actual;
            actual = target.OcrV2GetRecognizeDocument(name, storage, folder);

            Assert.AreEqual("OK", actual.Status);
            Assert.IsInstanceOfType(new OCRResponse(), actual.GetType());
        }

        /// <summary>
        ///A test for PostOcrFromUrlOrContent
        ///</summary>
        [TestMethod()]
        public void TestPostOcrFromUrlOrContent()
        {
            OcrApi target = new OcrApi(APIKEY, APPSID, BASEPATH);
            StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

            string name = "Dr._Jekyll_and_Mr._Hyde_Text.jpg";
            string url =  null;
            string language = "english";
            bool? doSpellCorrection = null;
            bool? skewCorrection = null;
            var file = System.IO.File.OpenRead(Path.Combine(DataFolder, name));
            
            Com.Aspose.Ocr.Model.OCRResponse actual;
            actual = target.OcrPostOcrFromUrlOrContent(url, language, doSpellCorrection, skewCorrection, file);

            Assert.AreEqual("OK", actual.Status);
            Assert.IsInstanceOfType(new OCRResponse(), actual.GetType()); 
        }

        /// <summary>
        ///A test for PostOcrFromUrlOrContent
        ///</summary>
        [TestMethod()]
        public void V2_TestPostOcrFromUrlOrContent()
        {
            OcrV2Api target = new OcrV2Api(APIKEY, APPSID, BASEPATH);
            
            string name = "Dr._Jekyll_and_Mr._Hyde_Text.jpg";
            string url = null;
            var file = System.IO.File.OpenRead(Path.Combine(DataFolder, name));

            Com.Aspose.Ocr.Model.OCRResponse actual;
            actual = target.OcrV2PostOcrFromUrlOrContent(url, file);

            Assert.AreEqual("OK", actual.Status);
            Assert.IsInstanceOfType(new OCRResponse(), actual.GetType());
        }

    }
}
