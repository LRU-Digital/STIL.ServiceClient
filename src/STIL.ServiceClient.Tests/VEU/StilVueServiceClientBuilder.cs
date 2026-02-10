using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using Moq;
using STIL.ServiceClient.ConfigurationProviders;
using STIL.ServiceClient.Tests.Util;

namespace STIL.ServiceClient.Tests.VEU
{
    internal class StilVueServiceClientBuilder
    {
        private Mock<ISoapServiceClient>? _soapServiceClientMock;
        private Mock<HttpClientHandler> _httpClientHandlerMock;
        private X509Certificate2 _signingCertificate;
        private X509Certificate2 _clientCertificate;
        private string _baseUrl;
        private string _areaAffixUrl;
        private IRetryPolicyProvider _retryPolicyProvider;

        public StilVueServiceClientBuilder()
        {
            _baseUrl = "http://test";
            _areaAffixUrl = "/VEU";
            var certificate = TestHelper.CreateSelfSignedCertificate("test", DateTime.Now, DateTime.Now.AddDays(1));
            _signingCertificate = certificate;
            _clientCertificate = certificate;
            _httpClientHandlerMock = new Mock<HttpClientHandler>(MockBehavior.Strict);
            _retryPolicyProvider = new DefaultRetryPolicyProvider();
        }

        public StilVueServiceClientBuilder WithBaseUrl(string baseUrl)
        {
            _baseUrl = baseUrl;
            return this;
        }

        public StilVueServiceClientBuilder With(Mock<ISoapServiceClient> soapServiceClientMock)
        {
            _soapServiceClientMock = soapServiceClientMock;
            return this;
        }

        public StilVueServiceClientBuilder With(Mock<HttpClientHandler> httpClientHandlerMock)
        {
            _httpClientHandlerMock = httpClientHandlerMock;
            return this;
        }

        public StilVueServiceClientBuilder WithSigningCertificate(X509Certificate2 signingCertificate)
        {
            _signingCertificate = signingCertificate;
            return this;
        }

        public StilVueServiceClientBuilder WithClientCertificate(X509Certificate2 clientCertificate)
        {
            _clientCertificate = clientCertificate;
            return this;
        }

        public StilVueServiceClientBuilder With(IRetryPolicyProvider retryPolicyProvider)
        {
            _retryPolicyProvider = retryPolicyProvider;
            return this;
        }

        public IStilVeuServiceClient Build()
        {
            // Return veu service client with mock of stil service client if this was created
            if (_soapServiceClientMock != null)
            {
                return new StilVeuServiceClient(_baseUrl, _soapServiceClientMock.Object, _signingCertificate);
            }

            // Create stil service client and set mocked http client handler.
            SoapServiceClient soapServiceClient = new(new HttpClient(_httpClientHandlerMock.Object), _retryPolicyProvider);
            _httpClientHandlerMock.Object.ClientCertificates.Add(_clientCertificate);
            
            return new StilVeuServiceClient(_baseUrl, soapServiceClient, _signingCertificate);
        }
    }
}
