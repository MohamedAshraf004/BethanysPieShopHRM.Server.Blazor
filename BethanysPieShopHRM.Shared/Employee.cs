using System;

namespace BethanysPieShopHRM.Shared
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string PhoneNumber { get; set; }
        public bool Smoker { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public string Comment { get; set; }
        public DateTime? JoinedDate { get; set; }
        public DateTime? ExitDate { get; set; }
        
        public int JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
