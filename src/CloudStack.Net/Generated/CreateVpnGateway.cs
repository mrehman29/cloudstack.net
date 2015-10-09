using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVpnGatewayRequest : APIRequest
    {
        public CreateVpnGatewayRequest() : base("createVpnGateway") {}

        /// <summary>
        /// public ip address id of the vpn gateway
        /// </summary>
        public Guid VpcId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the vpn to the end user or not
        /// </summary>
        public bool? Display { get; set; }

    }
    /// <summary>
    /// Creates site to site vpn local gateway
    /// </summary>
    /// <summary>
    /// Creates site to site vpn local gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        Site2SiteVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public Site2SiteVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request) => _proxy.Request<Site2SiteVpnGatewayResponse>(request);
    }
}