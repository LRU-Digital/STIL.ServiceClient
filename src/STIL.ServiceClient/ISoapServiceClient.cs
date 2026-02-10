using System;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace STIL.ServiceClient
{
    /// <summary>
    /// Soap client responsible for sending the soap request and instantiating http client.
    /// </summary>
    public interface ISoapServiceClient
    {
        /// <summary>
        /// Send Soap Request method.
        /// Can be overridden in any derived classes.
        /// </summary>
        /// <typeparam name="TRequest">The request type.</typeparam>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <typeparam name="TServiceFaultDetailer">The service fault detailer type.</typeparam>
        /// <param name="requestUri">The request uri.</param>
        /// <param name="dataRequest">The data request body.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The response instance of <typeparamref name="TResponse"/>.</returns>
        Task<TResponse> SendSoapRequest<TResponse, TServiceFaultDetailer>(Uri requestUri, string requestXml, CancellationToken cancellationToken = default)
            where TResponse : class
            where TServiceFaultDetailer : class;
    }
}
