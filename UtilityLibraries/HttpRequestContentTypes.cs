using System;
using System.Linq;
using System.Reflection;

namespace lu8890.UtilityLibraries
{
    public static class HttpRequestContentTypes
    {
        public const string TextPlain = "text/plain";
        public const string TextHtml = "text/html";
        public const string TextXml = "text/xml";
        public const string TextRichtext = "text/richtext";
        public const string TextScriptlet = "text/scriptlet";
        public const string AudioXAiff = "audio/x-aiff";
        public const string AudioBasic = "audio/basic";
        public const string AudioMid = "audio/mid";
        public const string AudioWav = "audio/wav";
        public const string ImageGif = "image/gif";
        public const string ImageJpeg = "image/jpeg";
        public const string ImagPjpeg = "image/pjpeg";
        public const string ImagePng = "image/png";
        public const string ImageXPng = "image/x-png";
        public const string ImageTiff = "image/tiff";
        public const string ImageBmp = "image/bmp";
        public const string ImageXXbitmap = "image/x-xbitmap";
        public const string ImageXJg = "image/x-jg";
        public const string ImageXEmf = "image/x-emf";
        public const string ImageXWmf = "image/x-wmf";
        public const string VideoAvi = "video/avi";
        public const string VideoMpeg = "video/mpeg";
        public const string ApplicationOctetStream = "application/octet-stream";
        public const string ApplicationPostscript = "application/postscript";
        public const string ApplicationBase64 = "application/base64";
        public const string ApplicationMacbinhex40 = "application/macbinhex40";
        public const string ApplicationPdf = "application/pdf";
        public const string ApplicationXml = "application/xml";
        public const string ApplicationAtomXml = "application/atom+xml";
        public const string ApplicationRssXml = "application/rss+xml";
        public const string ApplicationXCompressed = "application/x-compressed";
        public const string ApplicationXZipCompressed = "application/xml";
        public const string ApplicationXGzipCompressed = "application/x-gzip-compressed";
        public const string ApplicationJava = "application/java";
        public const string ApplicationXMsdownload = "application/x-msdownload";
        public const string ApplicationJson = "application/json";
        public const string ApplicationXMpegurl = "application/x-mpegurl";

        public static string GetHttpContentTypeStr(HttpcontentTypes contentType, string assemblyName = "UtilityLibraries")
        {
            if (contentType.Equals(HttpcontentTypes.Default))
                return string.Empty;

            Assembly currentAssembly = null;
            Type currentClass = null;

            if (!string.IsNullOrWhiteSpace(assemblyName))
            {
                currentAssembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(x =>
                    string.Compare(x.GetName().Name, assemblyName, StringComparison.OrdinalIgnoreCase) == 0);
            }
            else
            {
                foreach (var ass in AppDomain.CurrentDomain.GetAssemblies())
                {
                    currentClass = ass.GetTypes().FirstOrDefault(x =>
                        string.Compare(x.Name, "HttpRequestContentTypes", StringComparison.OrdinalIgnoreCase) == 0);
                    if (currentClass != null)
                    {
                        currentAssembly = ass;
                        break;
                    }
                }
            }

            if (currentAssembly == null)
                throw new NullReferenceException("Reflection failed to retrieve current running assembly");

            if(currentClass == null)
                currentClass = currentAssembly.GetTypes().FirstOrDefault(x =>
                    string.Compare(x.Name, "HttpRequestContentTypes", StringComparison.OrdinalIgnoreCase) == 0);

            if (currentClass == null)
                throw new NullReferenceException("Reflection failed to retrieve class info");

            var fieldValue = currentClass.GetField(contentType.ToString());
            if (fieldValue == null)
                throw new NullReferenceException("Reflection failed to retrieve class field: " + contentType);

            return fieldValue.GetValue(null).ToString();
        }
    }

    public enum HttpcontentTypes
    {
        TextPlain,
        TextHtml,
        TextXml,
        TextRichtext,
        TextScriptlet,
        AudioXAiff,
        AudioBasic,
        AudioMid,
        AudioWav,
        ImageGif,
        ImageJpeg,
        ImagPjpeg,
        ImagePng,
        ImageXPng,
        ImageTiff,
        ImageBmp,
        ImageXXbitmap,
        ImageXJg,
        ImageXEmf,
        ImageXWmf,
        VideoAvi,
        VideoMpeg,
        ApplicationOctetStream,
        ApplicationPostscript,
        ApplicationBase64,
        ApplicationMacbinhex40,
        ApplicationPdf,
        ApplicationXml,
        ApplicationAtomXml,
        ApplicationRssXml,
        ApplicationXCompressed,
        ApplicationXZipCompressed,
        ApplicationXGzipCompressed,
        ApplicationJava,
        ApplicationXMsdownload,
        ApplicationJson,
        ApplicationXMpegurl,
        Default
    }
}