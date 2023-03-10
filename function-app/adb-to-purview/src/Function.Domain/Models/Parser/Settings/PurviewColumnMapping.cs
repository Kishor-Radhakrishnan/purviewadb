// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Function.Domain.Models.Settings
{
    public class PurviewColumnMapping
    {
        public DatasetMapping DatasetMapping { get; set; } = new DatasetMapping();
        public List<ColumnMapping> ColumnMapping { get; set; } = new List<ColumnMapping>();
    }

    public class DatasetMapping
    {
        public string Source = "";
        public string Sink = "";
    }

    public class ColumnMapping
    {
        public string Source = "";
        public string Sink = "";
    }

}