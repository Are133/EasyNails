namespace EasyNails.Core.CustomEntities
{
    public class Metadata
    {
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public bool HasNextPages { get; set; }
        public bool HasPreviusPage { get; set; }

        public string NextPageUrl { get; set; } = string.Empty;
        public string PreviusPageUrl { get; set; } = string.Empty;
    }
}
