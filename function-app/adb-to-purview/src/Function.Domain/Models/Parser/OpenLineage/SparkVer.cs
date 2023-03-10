// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace Function.Domain.Models.OL
{
    public class SparkVer
    {
        [JsonProperty("spark-version")]
        public string SparkVersion = ""; 
        [JsonProperty("openlineage-spark-version")]
        public string OpenLineageSparkVersion = ""; 
    }
  
}