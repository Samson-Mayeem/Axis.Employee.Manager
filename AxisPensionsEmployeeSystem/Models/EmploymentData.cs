namespace AxisPensionsEmployeeSystem.Models
{
    public class EmploymentData
    {
        public int EmploymentId { get; set; }
        public int EmployeeBiodataId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Designation {get; set;}
        public string Jobgrade {get; set;}
        public string EmployeeType { get; set; }
        public string HeadOfDepartmentName { get; set; }
        public string ContractFrequencyCode { get; set; }
        public string ContractDuration { get; set; }
    }
}
