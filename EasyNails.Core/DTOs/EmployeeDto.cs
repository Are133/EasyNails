using EasyNails.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyNails.Core.DTOs
{
    public class EmployeeDto
    {
        #region Attributes

        #endregion

        #region Builder

        #endregion


        #region Properties
        public int Id { get; set; }
        public string EmployeeId { get; set; } = string.Empty;
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
        public int BranchId { get; set; }

        #endregion
    }
}
