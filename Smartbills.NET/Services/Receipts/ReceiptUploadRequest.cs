using System.IO;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Smartbills.NET.Services.Files;

namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptUploadRequest : FileUploadRequest
    {
    }

    public record BatchReceiptUploadRequest : BatchFileUploadRequest<ReceiptUploadRequest>
    {
    }
}
