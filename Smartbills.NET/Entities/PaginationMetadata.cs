using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities
{
    public record PaginationMetadata
    {
        [JsonPropertyName("count")]
        public int Count
        {
            get;
            set;
        } = 0;

        [JsonPropertyName("page_count")]

        public int PageCount
        {
            get;
            set;
        } = 0;

        [JsonPropertyName("current_page")]
        public int CurrentPage
        {
            get;
            set;
        } = 1;

        [JsonPropertyName("limit")]
        public int Limit
        {
            get;
            set;
        } = 50;
    }
}
