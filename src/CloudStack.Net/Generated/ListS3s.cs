using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListS3sRequest : APIRequest
    {
        public ListS3sRequest() : base("listS3s") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists S3s
    /// </summary>
    /// <summary>
    /// Lists S3s
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ImageStoreResponse> ListS3s(ListS3sRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ImageStoreResponse> ListS3s(ListS3sRequest request) => _proxy.Request<ListResponse<ImageStoreResponse>>(request);
    }
}