using EasyNails.Core.Entities;
using EasyNails.Infraestructure.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EasyNails.Infraestructure.Seeders
{
    public class SeedDbContextData
    {
        #region Attributes
        private readonly DataContext _dataContext;
        #endregion

        #region Builder
        public SeedDbContextData(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        #endregion


        #region Properties

        #endregion

        #region PrivateMethods
        private async Task CheckDataToDbAsync()
        {
            #region BranchDataSeed

            if (!_dataContext.Branches.Any())
            {
                _dataContext.Branches.Add(new Branch
                {
                    Name = "Sol y Luna",
                    BranchGuidId = Guid.NewGuid().ToString(),
                    Address = "Calle 2 Poblado c32",
                    IsActive = true,
                    

                });

                _dataContext.Branches.Add(new Branch
                {
                    Name = "Treja y Luna",
                    BranchGuidId = Guid.NewGuid().ToString(),
                    Address = "Calle 2 Poblado c32",
                    IsActive = false,

                });

                _dataContext.Branches.Add(new Branch
                {
                    Name = "Luz y Luna",
                    BranchGuidId = Guid.NewGuid().ToString(),
                    Address = "Calle 2 Poblado c32",
                    IsActive = true,

                });

                _dataContext.Branches.Add(new Branch
                {
                    Name = "Chomba y Luna",
                    BranchGuidId = Guid.NewGuid().ToString(),
                    Address = "Calle 2 Poblado c32",
                    IsActive = true,

                });

                _dataContext.Branches.Add(new Branch
                {
                    Name = "Angie y Luna",
                    BranchGuidId = Guid.NewGuid().ToString(),
                    Address = "Calle 2 Poblado c32",
                    IsActive = false,

                });

                await _dataContext.SaveChangesAsync();
            }
            #endregion

            #region EmployeeDataSeed
            if (!_dataContext.Employees.Any())
            {
                _dataContext.Employees.Add(new Employee
                {
                    FirstName = "Ana",
                    Surname = "Aguirre Betancurt",
                    DateOfBirth = DateTime.Now,
                    ImageCertificate = string.Empty,
                    Address = "Fraccionamiento el Encanto Numero 512",
                    ArrivalTime = DateTime.Now,
                    DepartureTime = DateTime.Now,
                    Speciality = 1,
                    ClientsServed = 100,
                    IsActive = true,
                    NumbersOfDelays = 10,
                    NumberOfFaults = 10,
                    EmployeeId = Guid.NewGuid().ToString(),
                    BranchId = 1

                });

                _dataContext.Employees.Add(new Employee
                {
                    FirstName = "Maria",
                    Surname = "Sanchez Lopez",
                    DateOfBirth = DateTime.Now,
                    ImageCertificate = string.Empty,
                    Address = "Fraccionamiento el Encanto Numero 150",
                    ArrivalTime = DateTime.Now,
                    DepartureTime = DateTime.Now,
                    Speciality = 1,
                    ClientsServed = 100,
                    IsActive = true,
                    NumbersOfDelays = 10,
                    NumberOfFaults = 10,
                    EmployeeId = Guid.NewGuid().ToString(),
                    BranchId = 2
                });

                _dataContext.Employees.Add(new Employee
                {
                    FirstName = "Adamaris",
                    Surname = "Marin Jimenez",
                    DateOfBirth = DateTime.Now,
                    ImageCertificate = string.Empty,
                    Address = "Fraccionamiento el Encanto Numero 100",
                    ArrivalTime = DateTime.Now,
                    DepartureTime = DateTime.Now,
                    Speciality = 1,
                    ClientsServed = 100,
                    IsActive = true,
                    NumbersOfDelays = 10,
                    NumberOfFaults = 10,
                    EmployeeId = Guid.NewGuid().ToString(),
                    BranchId = 4
                });

                await _dataContext.SaveChangesAsync();
            }
            #endregion

            
        }
        #endregion

        #region PublicMethods
        public async Task SeedDbAddData()
        {
            await _dataContext.Database.EnsureCreatedAsync();

            await CheckDataToDbAsync();
        }
        #endregion





    }
}
