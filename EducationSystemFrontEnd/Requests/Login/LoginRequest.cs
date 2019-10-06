using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EducationSystemFrontEnd.Requests.Login
{
    class LoginRequest
    {
        private readonly String LOGINURL = "http://localhost:8080/userRole";

        public String CredentialCheck(String persalNumber)
        {
            String Response = null;

            WebRequest requestObjGet = WebRequest.Create(LOGINURL + "/getRole/"+persalNumber);
            requestObjGet.Method = "GET";
            requestObjGet.Credentials = new NetworkCredential("admin", "password");
            HttpWebResponse ResponseObjGet = null;
            ResponseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            Response = getHttpResponse(ResponseObjGet);
            return Response;

        }
        private String getHttpResponse(HttpWebResponse httpResponse)
        {
            String ReturnResponse = null;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                ReturnResponse = streamReader.ReadToEnd();
                streamReader.Close();
            }

            return ReturnResponse;
        }

    }
}
