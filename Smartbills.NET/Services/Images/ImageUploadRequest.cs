using Smartbills.NET.Services.Files;

namespace Smartbills.NET.Services.Images
{
    public record ImageUploadRequest : FileUploadRequest
    {
    }

    public record BatchImageUploadRequest : BatchFileUploadRequest<ImageUploadRequest>
    {
    }
}