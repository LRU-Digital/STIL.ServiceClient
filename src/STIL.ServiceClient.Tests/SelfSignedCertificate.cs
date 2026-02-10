using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace STIL.ServiceClient.Tests;

public static class SelfSignedCertificate
{
    public static X509Certificate2 CreateRSA(int keySize, DateTimeOffset validFrom, DateTimeOffset expiry, string commonName)
    {
        using RSA keypair = RSA.Create(keySize);

        CertificateRequest req = new($"cn={commonName}", keypair, HashAlgorithmName.SHA256, RSASignaturePadding.Pss);
        X509Certificate2 cert = req.CreateSelfSigned(validFrom, expiry);

        return cert;
    }
}
