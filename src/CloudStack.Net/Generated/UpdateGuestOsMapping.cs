using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateGuestOsMappingRequest : APIRequest
    {
        public UpdateGuestOsMappingRequest() : base("updateGuestOsMapping") {}

        /// <summary>
        /// UUID of the Guest OS to hypervisor name Mapping
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Hypervisor specific name for this Guest OS
        /// </summary>
        public string OsNameForHypervisor { get; set; }

    }
    /// <summary>
    /// Updates the information about Guest OS to Hypervisor specific name mapping
    /// </summary>
    /// <summary>
    /// Updates the information about Guest OS to Hypervisor specific name mapping
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GuestOsMappingResponse UpdateGuestOsMapping(UpdateGuestOsMappingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GuestOsMappingResponse UpdateGuestOsMapping(UpdateGuestOsMappingRequest request) => _proxy.Request<GuestOsMappingResponse>(request);
    }
}
