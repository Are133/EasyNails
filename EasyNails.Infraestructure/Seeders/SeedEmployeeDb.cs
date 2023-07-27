using EasyNails.Core.Entities;
using EasyNails.Infraestructure.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EasyNails.Infraestructure.Seeders
{
    public class SeedEmployeeDb
    {
        private readonly DataContext _dataContext;
        public SeedEmployeeDb(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task SeedAsyncEmployee()
        {
            await _dataContext.Database.EnsureCreatedAsync();

            await CheckEmployeeTypeAsync();
        }

        private async Task CheckEmployeeTypeAsync()
        {
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
                    EmployeeId = Guid.NewGuid().ToString()
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
                    EmployeeId = Guid.NewGuid().ToString()
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
                    EmployeeId = Guid.NewGuid().ToString()
                });

                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
