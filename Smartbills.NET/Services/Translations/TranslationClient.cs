using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Translations
{
    public interface ITranslationClient<T> :
        ICreatable<TranslationCreateRequest<T>, SBTranslatedEntity>,
        IRetrievableById<SBTranslatedEntity>,
        IUpdatable<TranslationUpdateRequest<T>, SBTranslatedEntity>,
        IDeletable<SBTranslatedEntity>,
        IListable<TranslationListRequest, SBList<SBTranslatedEntity>>
    {
        Task<SBTranslatedEntity> CreateTranslationAsync(TranslationCreateRequest<T> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBTranslatedEntity> DeleteTranslationAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBTranslatedEntity> UpdateTranslationAsync(long id, TranslationUpdateRequest<T> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBTranslatedEntity> GetTranslationAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
}