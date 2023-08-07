using EasyNails.Core.CustomEntities;

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

        #region Properties
        public T Data { get; set; }
        public Metadata Meta { get; set; }
        #endregion

    }
}
