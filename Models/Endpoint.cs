using System;
using System.Collections.Generic;
using System.Text;

namespace SystemEndpointsDotnetCore.Models
{
    public class Endpoint
    {
        public string alias { get; set; }

        public ServiceAddress endpoint { get; set; }
    }
}
