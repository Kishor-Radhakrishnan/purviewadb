// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Function.Domain.Models.OL;

namespace Function.Domain.Helpers.Parser
{
    public interface IOlMessageEnrichment
    {
        public Task<EnrichedEvent?> GetEnrichedEvent(Event olEvent);
    }
}