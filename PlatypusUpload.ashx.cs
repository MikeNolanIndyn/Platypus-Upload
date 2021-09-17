using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Platypus_Upload
{
    /// <summary>
    /// Summary description for PlatypusUpload
    /// </summary>
    public class PlatypusUpload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}