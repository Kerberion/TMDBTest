using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace TMBDTest.Models
{
    public class GenericResponse<T>
    {
        public bool exito { get; set; }
        public string mensaje { get; set; }
        public T datos { get; set; }
        public HttpStatusCode httpStatusCode { get; set; }
        public GenericResponse()
        {
            exito = false;
            mensaje = string.Empty;
        }
    }
}
