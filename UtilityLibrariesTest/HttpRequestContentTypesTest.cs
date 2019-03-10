using lu8890.UtilityLibraries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lu8890.UtilityLibrariesTest
{
    [TestClass]
    public class HttpRequestContentTypesTest
    {
        [TestMethod]
        public void TestTextPlain()
        {
            RunTest(HttpcontentTypes.TextPlain);
        }

        [TestMethod]
        public void TestTextHtml()
        {
            RunTest(HttpcontentTypes.TextHtml);
        }

        [TestMethod]
        public void TestTextXml()
        {
            RunTest(HttpcontentTypes.TextXml);
        }

        [TestMethod]
        public void TestTextRichtext()
        {
            RunTest(HttpcontentTypes.TextRichtext);
        }

        [TestMethod]
        public void TestTextScriptlet()
        {
            RunTest(HttpcontentTypes.TextScriptlet);
        }

        [TestMethod]
        public void TestAudioXAiff()
        {
            RunTest(HttpcontentTypes.AudioXAiff);
        }

        [TestMethod]
        public void TestAudioBasic()
        {
            RunTest(HttpcontentTypes.AudioBasic);
        }

        [TestMethod]
        public void TestAudioMid()
        {
            RunTest(HttpcontentTypes.AudioMid);
        }

        [TestMethod]
        public void TestAudioWav()
        {
            RunTest(HttpcontentTypes.AudioWav);
        }

        [TestMethod]
        public void TestImageGif()
        {
            RunTest(HttpcontentTypes.ImageGif);
        }

        [TestMethod]
        public void TestImageJpeg()
        {
            RunTest(HttpcontentTypes.ImageJpeg);
        }

        [TestMethod]
        public void TestImagPjpeg()
        {
            RunTest(HttpcontentTypes.ImagPjpeg);
        }

        [TestMethod]
        public void TestImagePng()
        {
            RunTest(HttpcontentTypes.ImagePng);
        }

        [TestMethod]
        public void TestImageXPng()
        {
            RunTest(HttpcontentTypes.ImageXPng);
        }

        [TestMethod]
        public void TestImageTiff()
        {
            RunTest(HttpcontentTypes.ImageTiff);
        }

        [TestMethod]
        public void TestImageBmp()
        {
            RunTest(HttpcontentTypes.ImageBmp);
        }

        [TestMethod]
        public void TestImageXXbitmap()
        {
            RunTest(HttpcontentTypes.ImageXXbitmap);
        }

        [TestMethod]
        public void TestImageXJg()
        {
            RunTest(HttpcontentTypes.ImageXJg);
        }

        [TestMethod]
        public void TestImageXEmf()
        {
            RunTest(HttpcontentTypes.ImageXEmf);
        }

        [TestMethod]
        public void TestImageXWmf()
        {
            RunTest(HttpcontentTypes.ImageXWmf);
        }

        [TestMethod]
        public void TestVideoAvi()
        {
            RunTest(HttpcontentTypes.VideoAvi);
        }

        [TestMethod]
        public void TestVideoMpeg()
        {
            RunTest(HttpcontentTypes.VideoMpeg);
        }

        [TestMethod]
        public void TestApplicationOctetStream()
        {
            RunTest(HttpcontentTypes.ApplicationOctetStream);
        }

        [TestMethod]
        public void TestApplicationPostscript()
        {
            RunTest(HttpcontentTypes.ApplicationPostscript);
        }

        [TestMethod]
        public void TestApplicationBase64()
        {
            RunTest(HttpcontentTypes.ApplicationBase64);
        }

        [TestMethod]
        public void TestApplicationMacbinhex40()
        {
            RunTest(HttpcontentTypes.ApplicationMacbinhex40);
        }

        [TestMethod]
        public void TestApplicationPdf()
        {
            RunTest(HttpcontentTypes.ApplicationPdf);
        }

        [TestMethod]
        public void TestApplicationXml()
        {
            RunTest(HttpcontentTypes.ApplicationXml);
        }

        [TestMethod]
        public void TestApplicationAtomXml()
        {
            RunTest(HttpcontentTypes.ApplicationAtomXml);
        }

        [TestMethod]
        public void TestApplicationRssXml()
        {
            RunTest(HttpcontentTypes.ApplicationRssXml);
        }

        [TestMethod]
        public void TestApplicationXCompressed()
        {
            RunTest(HttpcontentTypes.ApplicationXCompressed);
        }

        [TestMethod]
        public void TestApplicationXZipCompressed()
        {
            RunTest(HttpcontentTypes.ApplicationXZipCompressed);
        }

        [TestMethod]
        public void TestApplicationXGzipCompressed()
        {
            RunTest(HttpcontentTypes.ApplicationXGzipCompressed);
        }

        [TestMethod]
        public void TestApplicationJava()
        {
            RunTest(HttpcontentTypes.ApplicationJava);
        }

        [TestMethod]
        public void TestApplicationXMsdownload()
        {
            RunTest(HttpcontentTypes.ApplicationXMsdownload);
        }

        [TestMethod]
        public void TestApplicationJson()
        {
            RunTest(HttpcontentTypes.ApplicationJson);
        }

        [TestMethod]
        public void TestApplicationXMpegurl()
        {
            RunTest(HttpcontentTypes.ApplicationXMpegurl);
        }

        [TestMethod]
        public void TestDefault()
        {
            RunTest(HttpcontentTypes.Default);
        }

        private void RunTest(HttpcontentTypes input)
        {
            var output = HttpRequestContentTypes.GetHttpContentTypeStr(input);

            switch (input)
            {
                case HttpcontentTypes.TextPlain:
                    Assert.AreEqual(output, "text/plain", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "text/plain" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.TextHtml:
                    Assert.AreEqual(output, "text/html", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "text/html" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.TextXml:
                    Assert.AreEqual(output, "text/xml", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "text/xml" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.TextRichtext:
                    Assert.AreEqual(output, "text/richtext", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "text/richtext" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.TextScriptlet:
                    Assert.AreEqual(output, "text/scriptlet", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "text/scriptlet" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.AudioXAiff:
                    Assert.AreEqual(output, "audio/x-aiff", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "audio/x-aiff" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.AudioBasic:
                    Assert.AreEqual(output, "audio/basic", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "audio/basic" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.AudioMid:
                    Assert.AreEqual(output, "audio/mid", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "audio/mid" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.AudioWav:
                    Assert.AreEqual(output, "audio/wav", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "audio/wav" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ImageGif:
                    Assert.AreEqual(output, "image/gif", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "image/gif" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ImageJpeg:
                    Assert.AreEqual(output, "image/jpeg", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "image/jpeg" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ImagPjpeg:
                    Assert.AreEqual(output, "image/pjpeg", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "image/pjpeg" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ImagePng:
                    Assert.AreEqual(output, "image/png", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "image/png" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ImageXPng:
                    Assert.AreEqual(output, "image/x-png", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "image/x-png" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ImageTiff:
                    Assert.AreEqual(output, "image/tiff", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "image/tiff" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ImageBmp:
                    Assert.AreEqual(output, "image/bmp", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "image/bmp" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ImageXXbitmap:
                    Assert.AreEqual(output, "image/x-xbitmap", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "image/x-xbitmap" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ImageXJg:
                    Assert.AreEqual(output, "image/x-jg", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "image/x-jg" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ImageXEmf:
                    Assert.AreEqual(output, "image/x-emf", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "image/x-emf" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ImageXWmf:
                    Assert.AreEqual(output, "image/x-wmf", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "image/x-wmf" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.VideoAvi:
                    Assert.AreEqual(output, "video/avi", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "video/avi" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.VideoMpeg:
                    Assert.AreEqual(output, "video/mpeg", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "video/mpeg" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationOctetStream:
                    Assert.AreEqual(output, "application/octet-stream", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/octet-stream" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationPostscript:
                    Assert.AreEqual(output, "application/postscript", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/postscript" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationBase64:
                    Assert.AreEqual(output, "application/base64", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/base64" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationMacbinhex40:
                    Assert.AreEqual(output, "application/macbinhex40", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/macbinhex40" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationPdf:
                    Assert.AreEqual(output, "application/pdf", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/pdf" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationXml:
                    Assert.AreEqual(output, "application/xml", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/xml" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationAtomXml:
                    Assert.AreEqual(output, "application/atom+xml", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/atom+xml" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationRssXml:
                    Assert.AreEqual(output, "application/rss+xml", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/rss+xml" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationXCompressed:
                    Assert.AreEqual(output, "application/x-compressed", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/x-compressed" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationXZipCompressed:
                    Assert.AreEqual(output, "application/xml", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/xml" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationXGzipCompressed:
                    Assert.AreEqual(output, "application/x-gzip-compressed", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/x-gzip-compressed" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationJava:
                    Assert.AreEqual(output, "application/java", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/java" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationXMsdownload:
                    Assert.AreEqual(output, "application/x-msdownload", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/x-msdownload" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationJson:
                    Assert.AreEqual(output, "application/json", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/json" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.ApplicationXMpegurl:
                    Assert.AreEqual(output, "application/x-mpegurl", "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "application/x-mpegurl" + "\n\tActual Output: " + output);
                    break;

                case HttpcontentTypes.Default:
                    Assert.AreEqual(output, string.Empty, "[Test Failure] Test case: " + input.ToString() + "\n\tExpected Output: " + "string.empty" + "\n\tActual Output: " + output);
                    break;
                default:
                {
                    Assert.Fail("Undefined HttpContenType: " + input);
                    break;
                }
            }
        }
    }
}
