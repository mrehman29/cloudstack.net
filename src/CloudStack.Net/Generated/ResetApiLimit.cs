using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResetApiLimitRequest : APIRequest
    {
        public ResetApiLimitRequest() : base("resetApiLimit") {}

        /// <summary>
        /// the ID of the acount whose limit to be reset
        /// </summary>
        public Guid AccountId { get; set; }

    }
    /// <summary>
    /// Reset api count
    /// </summary>
    /// <summary>
    /// Reset api count
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiLimitResponse ResetApiLimit(ResetApiLimitRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiLimitResponse ResetApiLimit(ResetApiLimitRequest request) => _proxy.Request<ApiLimitResponse>(request);
    }
}