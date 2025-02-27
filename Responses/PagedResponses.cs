using System.Text.Json.Serialization;

namespace Api.Responses
{
  public class PagedResponse<T> : Response<T>
  {
    [JsonConstructor]
    public PagedResponse(
        T? data,
        int totalCount,
        int currentPage = Configuration.DEFAULT_PAGE_INIT,
        int pageSize = Configuration.DEFAULT_PAGE_SIZE)
        : base(data)
    {
      Data = data;
      TotalCount = totalCount;
      CurrentPage = currentPage;
      PageSize = pageSize;
    }
    public PagedResponse(
        T? data,
        int code = Configuration.DEFAULT_CODE,
        string? message = null)
        : base(data, code, message)
    {
    }
    public int CurrentPage { get; set; } = Configuration.DEFAULT_PAGE_INIT;
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    public int PageSize { get; set; } = Configuration.DEFAULT_PAGE_SIZE;
    public int TotalCount { get; set; }
  }
}
