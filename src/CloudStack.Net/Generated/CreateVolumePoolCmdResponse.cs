using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVolumePoolCmdResponse
    {
        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}