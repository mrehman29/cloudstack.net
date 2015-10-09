using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTemplatePermissionsRequest : APIRequest
    {
        public ListTemplatePermissionsRequest() : base("listTemplatePermissions") {}

        /// <summary>
        /// the template ID
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// List template visibility and all accounts that have permissions to view this template.
    /// </summary>
    /// <summary>
    /// List template visibility and all accounts that have permissions to view this template.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplatePermissionsResponse ListTemplatePermissions(ListTemplatePermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplatePermissionsResponse ListTemplatePermissions(ListTemplatePermissionsRequest request) => _proxy.Request<TemplatePermissionsResponse>(request);
    }
}