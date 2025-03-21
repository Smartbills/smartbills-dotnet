using Smartbills.NET.Services.Files;
using System.Collections.Generic;

namespace Smartbills.NET.Services.Attachments
{
    public record AttachmentUploadRequest : FileUploadRequest
    {
    }

    public record AttachmentCreateRequest : AttachmentUploadRequest
    {
        public string Key { get; set; }
    }

    public record AttachmentBatchUploadRequest
    {
        public List<AttachmentCreateRequest> Attachments { get; set; } = new();
    }
}
