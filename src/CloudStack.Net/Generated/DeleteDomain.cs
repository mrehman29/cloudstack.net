using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteDomainRequest : APIRequest
    {
        public DeleteDomainRequest() : base("deleteDomain") {}

        /// <summary>
        /// ID of domain to delete
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// true if all domain resources (child domains, accounts) have to be cleaned up, false otherwise
        /// </summary>
        public bool? Cleanup { get; set; }

    }
    /// <summary>
    /// Deletes a specified domain
    /// </summary>
    /// <summary>
    /// Deletes a specified domain
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteDomain(DeleteDomainRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteDomain(DeleteDomainRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
