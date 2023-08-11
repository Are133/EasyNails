using EasyNails.Core.Entities;
using System;
using System.Threading.Tasks;

namespace EasyNails.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Employee> EmployeeRepository { get; }
        ISecurityRepository SecurityRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
