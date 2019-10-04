using EducationSystemFrontEnd.deserialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EducationSystemFrontEnd
{
    class AppointmentSend
    {

        private const String BASE_URL = "http://localhost:8080/appointment/create";
        public String AppointmentCreate()
        {
            string json = "{" +
              "\"appointment\":{" +
              "\"persalNumber\"     : \"2\"," +
              "\"appointmentToSee\" : \"Matt\"" +
              "}," +
              "\"appointment\":{" +
              "\"persalNumber\"     : \"2\"," +
              "\"appointmentToSee\" : \"j\"" +
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
            string response = "";
            String username = "admin";
            String password = "password";
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BASE_URL);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = json.Length;
            request.Headers.Add("Authorization", "Basic " + encoded);
            StreamWriter requestWriter = new StreamWriter(request.GetRequestStream(), System.Text.Encoding.ASCII);
            requestWriter.Write(json);
            requestWriter.Close();

            try
            {
                WebResponse webResponse = request.GetResponse();
                Stream webStream = webResponse.GetResponseStream();
                StreamReader responseReader = new StreamReader(webStream);
                response = responseReader.ReadToEnd();
                //Response responseValue = new Response(response);

               Console.Out.WriteLine(response);
                responseReader.Close();
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("-----------------");
                Console.Out.WriteLine(e.Message);
            }
            return response;
        }
    }
}
