﻿namespace CommonModels
{
    public class LocalizedBook:Document
    {
        public string ISBN { get; set; }
        public int NumberOfPages { get; set; }
        public string Authors { get; set; }
        public string OriginalPublisher { get; set; }
        public string CountryOfLocalization { get; set; }
        public string LocalPublisher { get; set; }
    }
}
