using EasyNails.Core.Entities;
using System.Threading.Tasks;

namespace EasyNails.Core.Interfaces
{
    public interface ISecurityRepository
    {
        Task<Security> GetLoginByCredentials(UserLogin login);
    }
}