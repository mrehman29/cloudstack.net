using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableStaticNatRequest : APIRequest
    {
        public DisableStaticNatRequest() : base("disableStaticNat") {}

        /// <summary>
        /// the public IP address ID for which static NAT feature is being disabled
        /// </summary>
        public Guid IpAddressId { get; set; }

    }
    /// <summary>
    /// Disables static rule for given IP address
    /// </summary>
    /// <summary>
    /// Disables static rule for given IP address
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DisableStaticNat(DisableStaticNatRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DisableStaticNat(DisableStaticNatRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}