using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ExpungeVirtualMachineRequest : APIRequest
    {
        public ExpungeVirtualMachineRequest() : base("expungeVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Expunge a virtual machine. Once expunged, it cannot be recoverd.
    /// </summary>
    /// <summary>
    /// Expunge a virtual machine. Once expunged, it cannot be recoverd.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ExpungeVirtualMachine(ExpungeVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ExpungeVirtualMachine(ExpungeVirtualMachineRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}