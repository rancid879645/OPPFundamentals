using System;

namespace CommonModels
{
    public class Patent:Document
    {
        public DateTime ExpirationDate { get; set; }
        public string UniqueId { get; set; }
    }
}
