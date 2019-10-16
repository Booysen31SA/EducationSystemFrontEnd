using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace EducationSystemFrontEnd.Requests.Login
{
    class LoginRequest
    {
        private readonly String LOGINURL = "http://localhost:8080/userRole";

        public String CredentialCheck(String persalNumber)
        {
            String Response = null;
            try
            {
                WebRequest requestObjGet = WebRequest.Create(LOGINURL + "/getRole/" + persalNumber);
                requestObjGet.Method = "GET";
                requestObjGet.Credentials = new NetworkCredential("admin", "password");
                HttpWebResponse ResponseObjGet = null;
                ResponseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
                Response = getHttpResponse(ResponseObjGet);
            }
            catch (Exception e)
            {
                String error = Convert.ToString(e);
                if (error.Contains("Unable to connect to the remote server"))
                {
                    MessageBox.Show("Server Seems to be down, Please Try again later", "Server Down");
                }
            }

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
