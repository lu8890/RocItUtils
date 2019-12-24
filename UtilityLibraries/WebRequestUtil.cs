using System;
using System.Net;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json.Linq;

namespace lu8890.RocIt.UtilityLibraries
{
    public enum HttpApiMethods
    {
        POST,
        DELETE,
        PUT,
        GET
    }

    public class HttpRequestResponse
    {
        public bool RequestSuccessed;
        public string ReturnMessage;
        public HttpStatusCode ResponseHttpStatusCode;

    }
    

    public class WebRequestUtil
    {
        internal static HttpRequestResponse GetHttpResponse(string url,
                                            X509Certificate2 cert,
                                            HttpApiMethods httpMethod,
                                            string postData,
                                            HttpcontentTypes contentType,
                                            string assemblyName,
                                            bool ignoreCert = false)
        {
            var responseMessages = new HttpRequestResponse();

            try
            {
                if (string.IsNullOrEmpty(url))
                    throw new ArgumentNullException(nameof(url));

                var apiUri = new Uri(url);
                if (!apiUri.IsAbsoluteUri)
                    throw new FormatException("[Error] parameter url is not properly formatted: " + url);

                if (!ignoreCert)
                {
                    if (cert == null)
                        throw new ArgumentNullException(nameof(cert));
                }

                if (!string.IsNullOrEmpty(postData))
                {
                    if (contentType.Equals(HttpcontentTypes.ApplicationJson))
                    {
                        JToken postDataJson = null;
                        try
                        {
                            postDataJson = JToken.Parse(postData);
                        }
                        catch (Exception)
                        {
                            throw new ArgumentNullException(nameof(postData));
                        }

                        if (!postDataJson.HasValues)
                            throw new NullReferenceException("[Error] parameter postData is empty");
                    }
                }

                var request = (HttpWebRequest)WebRequest.Create(url);
                if (!ignoreCert)
                {
                    request.ClientCertificates.Add(cert);
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls |
                                                       SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                }
                request.Method = httpMethod.ToString();
                if (!contentType.Equals(HttpcontentTypes.Default))
                    request.ContentType = HttpRequestContentTypes.GetHttpContentTypeStr(contentType, null);

                if ((httpMethod == HttpApiMethods.PUT) || (!string.IsNullOrEmpty(postData)))
                {
                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(postData);
                    }
                }

                var response = (HttpWebResponse)request.GetResponse();
                responseMessages.ResponseHttpStatusCode = response.StatusCode;

                if (response.StatusCode == HttpStatusCode.OK ||
                    response.StatusCode == HttpStatusCode.Created ||
                    response.StatusCode == HttpStatusCode.Accepted
                   )
                {
                    using (var responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            var reader = new StreamReader(responseStream, Encoding.UTF8);
                            responseMessages.ReturnMessage = reader.ReadToEnd();

                        }
                    }
                    responseMessages.RequestSuccessed = true;
                }
                else
                {
                    responseMessages.ReturnMessage = "Returned unexpected StatusCode: " + response.StatusCode;
                    responseMessages.RequestSuccessed = false;
                }

                response.Close();
            }
            catch (WebException exw)
            {
                if (exw.Response == null) throw;

                var responseStream = exw.Response.GetResponseStream();
                if (responseStream == null) throw;

                var message = exw.Message;
                using (var reader = new StreamReader(responseStream))
                {
                    message += reader.ReadToEnd();
                }

                throw new WebException(message.Trim());
            }

            return responseMessages;
        }

    }
}