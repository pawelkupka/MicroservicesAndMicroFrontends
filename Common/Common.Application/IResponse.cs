using System.Net;

namespace Common.Application
{
    public interface IResponse
    {
        HttpStatusCode StatusCode { get; init; }
    }
}
