// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace BookFast.Files.Client
{
    using Models;

    /// <summary>
    /// </summary>
    public partial interface IBookFastFilesAPI : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        Microsoft.Rest.ServiceClientCredentials Credentials { get; }


            /// <summary>
        /// Get a write access token for a new facility image
        /// </summary>
        /// <param name='id'>
        /// Facility ID
        /// </param>
        /// <param name='originalFileName'>
        /// Image file name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse<FileAccessTokenRepresentation>> GetFacilityImageUploadTokenWithHttpMessagesAsync(System.Guid id, string originalFileName = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a write access token for a new accommodation image
        /// </summary>
        /// <param name='id'>
        /// Accommodation ID
        /// </param>
        /// <param name='originalFileName'>
        /// Image file name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse<FileAccessTokenRepresentation>> GetAccommodationImageUploadTokenWithHttpMessagesAsync(System.Guid id, string originalFileName = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}
