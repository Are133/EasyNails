namespace EasyNaills.Api.Responses
{
    public class BaseApiResponse<T>
    {
        #region Builder
        public BaseApiResponse(T data)
        {
                Data = data;
        }
        #endregion
        public T Data { get; set; }
    }
}
