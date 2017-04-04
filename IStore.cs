using System;
using System.Collections.Generic;
using System.Text;

namespace SystemEndpointsDotnetCore
{
    public interface IStore
    {
        string GetServiceAddress(string addr);
    }
}
