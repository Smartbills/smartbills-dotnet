using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Attachments;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Attachments
{
    public interface IAttachmentClient :
       IRetrievableById<SBAttachment>,
        ICreatable<AttachmentCreateRequest, SBAttachment>,
        IDeletable<SBAttachment>

    {
        Task<SBAttachment> RenameAsyncAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
    public class AttachmentClient :
        Service<SBAttachment>,
        IAttachmentClient
    {

        public AttachmentClient(ISmartbillsClient client) : base(client) { }


        public async Task<SBAttachment> CreateAsync(AttachmentCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/Attachments", request, options, cancellationToken);
        }
        public async Task<SBAttachment> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/Attachments/{id}", options, cancellationToken);
        }

        public async Task<SBAttachment> RenameAsyncAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/Attachments/{id}/rename", options, cancellationToken);
        }

        public async Task<SBAttachment> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/Attachments/{id}", options, cancellationToken);
        }
    }
}
