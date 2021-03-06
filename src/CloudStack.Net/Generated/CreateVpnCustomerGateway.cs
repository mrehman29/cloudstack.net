using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVpnCustomerGatewayRequest : APIRequest
    {
        public CreateVpnCustomerGatewayRequest() : base("createVpnCustomerGateway") {}

        /// <summary>
        /// guest cidr list of the customer gateway
        /// </summary>
        public string Cidrlist {
            get { return GetParameterValue<string>(nameof(Cidrlist).ToLower()); }
            set { SetParameterValue(nameof(Cidrlist).ToLower(), value); }
        }

        /// <summary>
        /// ESP policy of the customer gateway
        /// </summary>
        public string EspPolicy {
            get { return GetParameterValue<string>(nameof(EspPolicy).ToLower()); }
            set { SetParameterValue(nameof(EspPolicy).ToLower(), value); }
        }

        /// <summary>
        /// public ip address id of the customer gateway
        /// </summary>
        public string Gateway {
            get { return GetParameterValue<string>(nameof(Gateway).ToLower()); }
            set { SetParameterValue(nameof(Gateway).ToLower(), value); }
        }

        /// <summary>
        /// IKE policy of the customer gateway
        /// </summary>
        public string IkePolicy {
            get { return GetParameterValue<string>(nameof(IkePolicy).ToLower()); }
            set { SetParameterValue(nameof(IkePolicy).ToLower(), value); }
        }

        /// <summary>
        /// IPsec Preshared-Key of the customer gateway
        /// </summary>
        public string IpsecPsk {
            get { return GetParameterValue<string>(nameof(IpsecPsk).ToLower()); }
            set { SetParameterValue(nameof(IpsecPsk).ToLower(), value); }
        }

        /// <summary>
        /// the account associated with the gateway. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the domain ID associated with the gateway. If used with the account parameter returns the gateway associated with the account for the specified domain.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// If DPD is enabled for VPN connection
        /// </summary>
        public bool? Dpd {
            get { return GetParameterValue<bool?>(nameof(Dpd).ToLower()); }
            set { SetParameterValue(nameof(Dpd).ToLower(), value); }
        }

        /// <summary>
        /// Lifetime of phase 2 VPN connection to the customer gateway, in seconds
        /// </summary>
        public long? EspLifetime {
            get { return GetParameterValue<long?>(nameof(EspLifetime).ToLower()); }
            set { SetParameterValue(nameof(EspLifetime).ToLower(), value); }
        }

        /// <summary>
        /// Force Encapsulation for NAT traversal
        /// </summary>
        public bool? Forceencap {
            get { return GetParameterValue<bool?>(nameof(Forceencap).ToLower()); }
            set { SetParameterValue(nameof(Forceencap).ToLower(), value); }
        }

        /// <summary>
        /// Lifetime of phase 1 VPN connection to the customer gateway, in seconds
        /// </summary>
        public long? IkeLifetime {
            get { return GetParameterValue<long?>(nameof(IkeLifetime).ToLower()); }
            set { SetParameterValue(nameof(IkeLifetime).ToLower(), value); }
        }

        /// <summary>
        /// name of this customer gateway
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// create site-to-site VPN customer gateway for the project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates site to site vpn customer gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateVpnCustomerGateway(CreateVpnCustomerGatewayRequest request);
        Task<AsyncJobResponse> CreateVpnCustomerGatewayAsync(CreateVpnCustomerGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateVpnCustomerGateway(CreateVpnCustomerGatewayRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateVpnCustomerGatewayAsync(CreateVpnCustomerGatewayRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
