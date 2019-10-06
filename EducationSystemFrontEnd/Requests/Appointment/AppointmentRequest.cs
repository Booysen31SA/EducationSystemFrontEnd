using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EducationSystemFrontEnd.Requests.Appointment
{
    class AppointmentRequest
    {
        private readonly String AppointmentURL = "http://localhost:8080/appointment";
     public string CreateAppointment()
        {
            String Response = "Created";
            string Json = "{" +
            "\"appointment\":{" +
            "\"persalNumber\"     : \"2\"," +
            "\"appointmentToSee\" : \"Matt\"" +
            "}," +
            "\"dateAndTime\":{" +
            "\"persal_Number\" : \"2\"," +
            "\"date\"          : \"17/5\"," +
            "\"time\"          : \"17h30\"" +
            "}," +
            "\"reason\":{" +
            "\"persal_Number\" : \"2\"," +
            "\"reason\"        : \"vist\"" +
            "}" +
            "}"
            ;
            WebRequest requestObjPost = WebRequest.Create(AppointmentURL+"/create");
            requestObjPost.Method = "POST";
            requestObjPost.ContentType = "application/json";
            requestObjPost.Credentials = new NetworkCredential("admin", "password");

            Response = getHttpResponse(sendResponse(requestObjPost, Json));
            return Response;
        }

        private HttpWebResponse sendResponse(WebRequest sendHttpResponse, String JsonData)
        {
            HttpWebResponse httpResponse = null;
            using (var streamWriter = new StreamWriter(sendHttpResponse.GetRequestStream()))
            {
                streamWriter.Write(JsonData);
                streamWriter.Flush();
                streamWriter.Close();

                httpResponse = (HttpWebResponse)sendHttpResponse.GetResponse();
            }
            return httpResponse;
        }

        private String getHttpResponse(HttpWebResponse httpResponse)
        {
            String ReturnResponse = null;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                ReturnResponse = streamReader.ReadToEnd();
            }

            return ReturnResponse;
        }
    }
}
