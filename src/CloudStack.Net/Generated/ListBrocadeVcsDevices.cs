using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBrocadeVcsDevicesRequest : APIListRequest
    {
        public ListBrocadeVcsDevicesRequest() : base("listBrocadeVcsDevices") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid? PhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// Brocade VCS switch ID
        /// </summary>
        public Guid? Vcsdeviceid {
            get { return GetParameterValue<Guid?>(nameof(Vcsdeviceid).ToLower()); }
            set { SetParameterValue(nameof(Vcsdeviceid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists Brocade VCS Switches
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BrocadeVcsDeviceResponse> ListBrocadeVcsDevices(ListBrocadeVcsDevicesRequest request);
        Task<ListResponse<BrocadeVcsDeviceResponse>> ListBrocadeVcsDevicesAsync(ListBrocadeVcsDevicesRequest request);
        ListResponse<BrocadeVcsDeviceResponse> ListBrocadeVcsDevicesAllPages(ListBrocadeVcsDevicesRequest request);
        Task<ListResponse<BrocadeVcsDeviceResponse>> ListBrocadeVcsDevicesAllPagesAsync(ListBrocadeVcsDevicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BrocadeVcsDeviceResponse> ListBrocadeVcsDevices(ListBrocadeVcsDevicesRequest request) => _proxy.Request<ListResponse<BrocadeVcsDeviceResponse>>(request);
        public Task<ListResponse<BrocadeVcsDeviceResponse>> ListBrocadeVcsDevicesAsync(ListBrocadeVcsDevicesRequest request) => _proxy.RequestAsync<ListResponse<BrocadeVcsDeviceResponse>>(request);
        public ListResponse<BrocadeVcsDeviceResponse> ListBrocadeVcsDevicesAllPages(ListBrocadeVcsDevicesRequest request) => _proxy.RequestAllPages<BrocadeVcsDeviceResponse>(request);
        public Task<ListResponse<BrocadeVcsDeviceResponse>> ListBrocadeVcsDevicesAllPagesAsync(ListBrocadeVcsDevicesRequest request) => _proxy.RequestAllPagesAsync<BrocadeVcsDeviceResponse>(request);
    }
}
