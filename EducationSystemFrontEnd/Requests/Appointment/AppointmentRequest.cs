using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationSystemFrontEnd.Requests.Appointment
{
    class AppointmentRequest
    {
        private readonly String AppointmentURL = "http://localhost:8080/appointment";

        public String GetAllAppointments()
        {
            String Response = null;
            WebRequest requestObjGet = WebRequest.Create(AppointmentURL + "/getall");
            requestObjGet.Method = "GET";
            requestObjGet.Credentials = new NetworkCredential("admin", "password");
            HttpWebResponse ResponseObjGet = null;
            ResponseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            Response = getHttpResponse(ResponseObjGet);
            return Response;
        }
     public string CreateAppointment(String persalNumber, String appointToSee, String date,String time, String reason, String role)
        {
            EducationSystem Education = new EducationSystem();
            String Response = "Created";
            string Json = "{" +
            "\"appointment\":{" +
            "\"persalNumber\"     : \""+persalNumber+"\"," +
            "\"appointmentToSee\" : \""+appointToSee+"\"" +
            "}," +
            "\"dateAndTime\":{" +
            "\"persal_Number\" : \"" + persalNumber + "\"," +
            "\"date\"          : \"" + date + "\"," +
            "\"time\"          : \"" + time + "\"" +
            "}," +
            "\"reason\":{" +
            "\"persal_Number\" : \"" + persalNumber + "\"," +
            "\"reason\"        : \"" + reason + "\"" +
            "}" +
            "}"
            ;
            WebRequest requestObjPost = WebRequest.Create(AppointmentURL+"/create");
            requestObjPost.Method = "POST";
            requestObjPost.ContentType = "application/json";

            requestObjPost.Credentials = new NetworkCredential(role, Education.getPassword());

            Response = getHttpResponse(sendResponse(requestObjPost, Json));
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
           if(httpResponse != null)
            {
               using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    ReturnResponse = streamReader.ReadToEnd();
                }
            }
            else{ }

            return ReturnResponse;
        }
    }
}
