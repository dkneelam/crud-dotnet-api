namespace crud_dotnet_api.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public string? Designation { get; set; }
        public int MgrId { get; set; }

    }
}
