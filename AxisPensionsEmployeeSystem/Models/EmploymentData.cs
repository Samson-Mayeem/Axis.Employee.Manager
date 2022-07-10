namespace AxisPensionsEmployeeSystem.Models
{
    public class EmploymentData
    {
        public int EmploymentId { get; set; }
        public int EmployeeBiodataId { get; set; }
        public string FirstName { get; set; }
        private string Surname { get; set; }
        private string Designation {get; set;}
        private string Jobgrade {get; set;}
        private string EmployeeType { get; set; }
        private string HeadOfDepartmentName { get; set; }
        private string ContractFrequencyCode { get; set; }
        private string ContractDuration { get; set; }
    }
}
