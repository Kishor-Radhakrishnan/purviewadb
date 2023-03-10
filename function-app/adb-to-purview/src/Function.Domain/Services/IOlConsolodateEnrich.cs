// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Function.Domain.Models.OL;

namespace Function.Domain.Services
{
    public interface IOlConsolodateEnrich
    {
        public Task<EnrichedEvent?> ProcessOlMessage(string strEvent);
        public string GetJobNamespace();
    }
}