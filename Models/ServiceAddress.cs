using System;
using System.Collections.Generic;
using System.Text;

namespace SystemEndpointsDotnetCore.Models
{
    public class ServiceAddress
    {
        public string host { get; set; }

        public string port { get; set; }

        public string GetFullUrl()
        {
            return $"{host}:{port}";
        }
    }
}
