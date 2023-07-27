using System;

namespace EasyNails.Core.Entities
{
    public class Employee
    {

        #region Properties
        public int Id { get; set; }

        public string EmployeeId { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string ImageCertificate { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public int Speciality { get; set; }
        public decimal Commission { get; set; }
        public int ClientsServed { get; set; }
        public bool IsActive { get; set; }
        public int NumbersOfDelays { get; set; }
        public int NumberOfFaults { get; set; }

        public Branch? Branch { get; set; }

        public int BranchId { get; set; }

        #endregion

        #region PrivateMethods
        private void SetGuidEmployeeId()
        {
            EmployeeId = $"{FirstName.Substring(2)} {Surname.Substring(2)} {Guid.NewGuid()}";
        }
        #endregion

    }
}
