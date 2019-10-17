using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace EducationSystemFrontEnd.Requests.Retirement
{
    internal class RetirementRequest
    {
        private readonly String RetirementURL = "http://localhost:8080/retirement";
        private EducationSystem Education = new EducationSystem();
        private int i = 0;

        public String GetAllRetirements(String get)
        {
            String Response = null;

            try
            {
                WebRequest requestObjGet = WebRequest.Create(RetirementURL + "/getall/" + get);
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

        public string CreateRetirement(String persalNumber, String id, String firstName, String lastName, double payout, String request, String role)
        {
            String Response = "Created";
            string Json = "{" +
            "\"retirement\":{" +
            "\"persal_Num\"     : \"" + persalNumber + "\"," +
            "\"iD\" : \"" + id + "\"," +
            "\"firstName\" : \"" + firstName + "\"," +
            "\"lastName\" : \"" + lastName + "\"," +
            "\"payout\" : " + payout + "" +
            "}," +
            "\"status\":{" +
            "\"persal_Number\" : \"" + persalNumber + "\"," +
            "\"request\"          : \"" + request + "\"" +
            "}" +
            "}"
            ;
            WebRequest requestObjPost = WebRequest.Create(RetirementURL + "/create");
            requestObjPost.Method = "POST";
            requestObjPost.ContentType = "application/json";

            requestObjPost.Credentials = new NetworkCredential(role, Education.getPassword());

            Response = getHttpResponse(sendResponse(requestObjPost, Json));
            return Response;
        }

        public String Read(String get, String Role)
        {
            String Response = null;

            try
            {
                WebRequest requestObjGet = WebRequest.Create(RetirementURL + "/read/" + get);
                requestObjGet.Method = "GET";
                requestObjGet.Credentials = new NetworkCredential(Role, Education.getPassword());
                HttpWebResponse ResponseObjGet = null;
                ResponseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
                Response = getHttpResponse(ResponseObjGet);
            }
            catch (WebException e)
            {
                String error = e.ToString();
                if (error.Contains("The remote server returned an error: (500) Internal Server Error"))
                {
                    MessageBox.Show("User Dont Exist");
                }
                else if (error.Contains("The remote server returned an error: (403) Forbidden"))
                {
                    MessageBox.Show("unauthorized Access, You Do not have the Required Permission");
                }
            }
            return Response;
        }

        public String DeleteAppointment(String get, String Role)
        {
            String Response = null;

            try
            {
                WebRequest requestObjGet = WebRequest.Create(RetirementURL + "/delete/" + get);
                requestObjGet.Method = "GET";
                requestObjGet.Credentials = new NetworkCredential(Role, Education.getPassword());
                HttpWebResponse ResponseObjGet = null;
                ResponseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
                Response = getHttpResponse(ResponseObjGet);
            }
            catch (WebException e)
            {
                String error = e.ToString();
                if (error.Contains("The remote server returned an error: (500) Internal Server Error"))
                {
                    MessageBox.Show("User Dont Exist");
                }
                else if (error.Contains("The remote server returned an error: (403) Forbidden"))
                {
                    MessageBox.Show("unauthorized Access, You Do not have the Required Permission");
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