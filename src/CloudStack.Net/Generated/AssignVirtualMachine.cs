using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AssignVirtualMachineRequest : APIRequest
    {
        public AssignVirtualMachineRequest() : base("assignVirtualMachine") {}

        /// <summary>
        /// account name of the new VM owner.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// domain id of the new VM owner.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// id of the VM to be moved
        /// </summary>
        public Guid VirtualMachineId { get; set; }

        /// <summary>
        /// list of new network ids in which the moved VM will participate. In case no network ids are provided the VM will be part of the default network for that zone. In case there is no network yet created for the new account the default network will be created.
        /// </summary>
        public IList<long> NetworkIds { get; set; }

        /// <summary>
        /// list of security group ids to be applied on the virtual machine. In case no security groups are provided the VM is part of the default security group.
        /// </summary>
        public IList<long> SecurityGroupIdList { get; set; }

    }
    /// <summary>
    /// Change ownership of a VM from one account to another. This API is available for Basic zones with security groups and Advanced zones with guest networks. A root administrator can reassign a VM from any account to any other account in any domain. A domain administrator can reassign a VM to any account in the same domain.
    /// </summary>
    /// <summary>
    /// Change ownership of a VM from one account to another. This API is available for Basic zones with security groups and Advanced zones with guest networks. A root administrator can reassign a VM from any account to any other account in any domain. A domain administrator can reassign a VM to any account in the same domain.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse AssignVirtualMachine(AssignVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse AssignVirtualMachine(AssignVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}