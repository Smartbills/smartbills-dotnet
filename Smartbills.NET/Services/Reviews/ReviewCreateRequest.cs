using Smartbills.NET.Services.Translations;
using System.Collections.Generic;

namespace Smartbills.NET.Services.Reviews
{
    public record ReviewCreateRequest : TranslationCreateRequest<ReviewTranslationCreateRequest>
    {
        public int Rating { get; set; }
        public string Comment { get; set; }
        public long ReceiptId { get; set; }
    }
}
