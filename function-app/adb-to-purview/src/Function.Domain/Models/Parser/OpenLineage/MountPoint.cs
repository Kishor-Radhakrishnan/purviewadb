// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace Function.Domain.Models.OL
{
    public class MountPoint
    {
        [JsonProperty("MountPoint")]
        public string MountPointName {get; set; } = "";
        public string Source {get; set; } = "";
    }
}