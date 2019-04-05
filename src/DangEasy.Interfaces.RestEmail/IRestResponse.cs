using System;
using System.Net;

namespace DangEasy.Interfaces.RestEmail
{
    public interface IRestResponse
    {
        HttpStatusCode StatusCode { get; }
        string Content { get; }
        Exception Exception { get; }
    }
}
