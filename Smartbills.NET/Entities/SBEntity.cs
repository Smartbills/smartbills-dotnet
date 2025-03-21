
namespace Smartbills.NET.Entities
{
    public record SBEntity
    {
        public long Id { get; set; }
    }

    public interface ISBEntity
    {
        long Id { get; set; }
    }
}