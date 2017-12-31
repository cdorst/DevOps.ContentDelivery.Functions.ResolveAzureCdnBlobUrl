using DevOps.ContentDelivery.Structures.AzureBlob;
using System;
using static DevOps.ContentDelivery.Functions.ResolveAzureCdnContentUrl.UrlResolver;

namespace DevOps.ContentDelivery.Functions.ResolveAzureCdnBlobUrl
{
    public static class UrlResolver
    {
        public static Uri Uri(string endpointName, Blob blob)
            => Url(endpointName, $"{blob.Container}/{blob.Name}");
    }
}
