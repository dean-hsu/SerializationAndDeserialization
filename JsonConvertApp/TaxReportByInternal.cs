﻿
namespace JsonConvertApp
{
    public class TaxReportByInternal
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Order { get; set; }
        public string Version { internal get; set; }
        public bool IsNew => Version == "2";
    }
}
