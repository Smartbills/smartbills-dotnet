using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities
{
    public record PaginationMetadata
    {
        
        public int Count
        {
            get;
            set;
        } = 0;

        

        public int PageCount
        {
            get;
            set;
        } = 0;

        
        public int CurrentPage
        {
            get;
            set;
        } = 1;

        
        public int Limit
        {
            get;
            set;
        } = 50;
    }
}
