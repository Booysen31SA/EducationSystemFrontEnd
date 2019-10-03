using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationSystemFrontEnd.deserialize
{
    class Response
    {
        private String responseCode, responseDescription;
        private Object response;

        public Response(String responseCode, String responseDescription)
        {
            this.responseCode = responseCode;
            this.responseDescription = responseDescription;
        }

         public String getResponseCode() {
        return responseCode;
    }

    public void setResponseCode(String responseCode) {
        this.responseCode = responseCode;
    }

    public String getResponseDescription() {
        return responseDescription;
    }

    public void setResponseDescription(String responseDescription) {
        this.responseDescription = responseDescription;
    }

    public Object getResponse() {
        return response;
    }

    public void setResponse(Object response) {
        this.response = response;
    }

    }
}
