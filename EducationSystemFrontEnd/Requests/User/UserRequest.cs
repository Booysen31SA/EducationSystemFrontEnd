using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationSystemFrontEnd.Requests.User
{
    class UserRequest
    {
        private readonly String TransferURL = "http://localhost:8080/teacher";
        private EducationSystem Education = new EducationSystem();
        private int i = 0;

        public String GetAllAppointments(String get)
        {
            String Response = null;

            try
            {

                WebRequest requestObjGet = WebRequest.Create(TransferURL + "/getall/" + get);
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
        public string CreateRetirement(String persalNumber, String id, String firstName, String lastName, String date, String address, String postalAddress, String userRole, String gender, String race, String role)
        {

            String Response = "Created";
            string Json = "{" +
            "\"transfer\":{" +
            "\"persalNumber\"     : \"" + persalNumber + "\"," +
            "\"id\" : \"" + id + "\"," +
            "\"first_Name\" : \"" + firstName + "\"," +
            "\"last_Name\" : " + lastName + "" +
            "}," +
            "\"dateAppointed\":{" +
            "\"persal_Number\" : \"" + persalNumber + "\"," +
            "\"date\" : \"" + date + "\"" +
            "}," +
            "\"address\":{" +
            "\"persal_Number\" : \"" + persalNumber + "\"," +
            "\"physicalAddress\" : \"" + address + "\"," +
            "\"postalAddress\" : \"" + postalAddress + "\"" +
            "}," +
            "\"userRole\":{" +
            "\"persal_Number\" : \"" + persalNumber + "\"," +
            "\"userRole\" : \"" + userRole + "\"," +
            "\"userPassword\" : \"password\"" +
            "}" +
            "}"
            ;
            WebRequest requestObjPost = WebRequest.Create(TransferURL + "/create/"+gender+"/"+race);
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
