using lu8890.UtilityLibraries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lu8890.UtilityLibrariesTest
{
    [TestClass]
    public class WebconfigObjTest
    {
        [TestMethod]
        public void Test_HasKey_Negative()
        {
            var webconfig = new WebconfigObj();
            Assert.IsFalse(webconfig.HasKey("negativeTest"), "[Test Failed] key negativeTest should not exist in the app.config");
        }

        [TestMethod]
        public void Test_HasKey()
        {
            var webconfig = new WebconfigObj();
            Assert.IsTrue(webconfig.HasKey("configTest1"), "[Test Failed] key configTest1 should exist in the app.config");
            Assert.IsTrue(webconfig.HasKey("configTest2"), "[Test Failed] key configTest2 should exist in the app.config");
        }

        [TestMethod]
        public void Test_GetValue()
        {
            var webconfig = new WebconfigObj();
            Assert.AreEqual(webconfig.GetValue("configTest1"), "value1", "[Test Failed] expected value: value1, actual value: " + webconfig.GetValue("configTest1"));
            Assert.AreEqual(webconfig.GetValue("configTest2"), "2", "[Test Failed] expected value: value1, actual value: " + webconfig.GetValue("configTest2"));
        }
    }
}
