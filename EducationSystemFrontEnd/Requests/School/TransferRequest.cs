using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace EducationSystemFrontEnd.Requests.School
{
    internal class TransferRequest
    {
        private readonly String TransferURL = "http://localhost:8080/transfer";
        private EducationSystem Education = new EducationSystem();
        private int i = 0;

        public String GetAllAppointments(String get)
        {
            String Response = null;

            try
            {
                WebRequest requestObjGet = WebRequest.Create(TransferURL + "/getall" + get);
                requestObjGet.Method = "GET";
                requestObjGet.Credentials = new NetworkCredential("admin", "password");
                HttpWebResponse ResponseObjGet = null;
                ResponseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
                Response = getHttpResponse(ResponseObjGet);
            }
            catch (WebException)
            {
                i++;
                if (i == 2)
                {
                    MessageBox.Show("unauthorized, No access allowed");
                }
            }
            return Response;
        }

        public string CreateRetirement(String persalNumber, String previousSchool, String SchoolName, int payout, String request, String role)
        {
            String Response = "Created";
            string Json = "{" +
            "\"transfer\":{" +
            "\"persalNumber\"     : \"" + persalNumber + "\"," +
            "\"previousSchool\" : \"" + previousSchool + "\"," +
            "\"schoolName\" : \"" + SchoolName + "\"," +
            "\"teacherAmount\" : " + payout + "" +
            "}," +
            "\"status\":{" +
            "\"persal_Number\" : \"" + persalNumber + "\"," +
            "\"statusRequest\" : \"" + request + "\"" +
            "}" +
            "}"
            ;
            WebRequest requestObjPost = WebRequest.Create(TransferURL + "/create");
            requestObjPost.Method = "POST";
            requestObjPost.ContentType = "application/json";

            requestObjPost.Credentials = new NetworkCredential(role, Education.getPassword());

            Response = getHttpResponse(sendResponse(requestObjPost, Json));
            return Response;
        }

        public String ReadAppointment(String get, String Role)
        {
            String Response = null;

            try
            {
                WebRequest requestObjGet = WebRequest.Create(TransferURL + "/read/" + get);
                requestObjGet.Method = "GET";
                requestObjGet.Credentials = new NetworkCredential(Role, Education.getPassword());
                HttpWebResponse ResponseObjGet = null;
                ResponseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
                Response = getHttpResponse(ResponseObjGet);
            }
            catch (WebException)
            {
                i++;
                if (i == 2)
                {
                    MessageBox.Show("unauthorized, No access allowed");
                }
            }
            return Response;
        }

        public String DeleteAppointment(String get, String Role)
        {
            String Response = null;

            try
            {
                WebRequest requestObjGet = WebRequest.Create(TransferURL + "/delete/" + get);
                requestObjGet.Method = "GET";
                requestObjGet.Credentials = new NetworkCredential(Role, Education.getPassword());
                HttpWebResponse ResponseObjGet = null;
                ResponseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
                Response = getHttpResponse(ResponseObjGet);
            }
            catch (WebException)
            {
                i++;
                if (i == 2)
                {
                    MessageBox.Show("unauthorized, No access allowed");
                }
            }
            return Response;
        }

        private HttpWebResponse sendResponse(WebRequest sendHttpResponse, String JsonData)
        {
            HttpWebResponse httpResponse = null;
            try
            {
                using (var streamWriter = new StreamWriter(sendHttpResponse.GetRequestStream()))
                {
                    streamWriter.Write(JsonData);
                    streamWriter.Flush();
                    streamWriter.Close();

                    httpResponse = (HttpWebResponse)sendHttpResponse.GetResponse();
                }
            }
            catch (WebException)
            {
                MessageBox.Show("unauthorized, No access allowed");
            }
            return httpResponse;
        }

        private String getHttpResponse(HttpWebResponse httpResponse)
        {
            String ReturnResponse = null;
            if (httpResponse != null)
            {
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    ReturnResponse = streamReader.ReadToEnd();
                    streamReader.Close();
                }
            }
            else { }

            return ReturnResponse;
        }
    }
}