// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Newtonsoft.Json;
namespace Function.Domain.Models.Purview
{
    public class DatabricksProcessRelationshipAttributes
    {
        [JsonProperty("task")]
        public RelationshipAttribute Task = new RelationshipAttribute();
    }

}