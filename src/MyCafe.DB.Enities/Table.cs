namespace MyCafe.DB.Enities
{
    public class Table
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string Name { get; set; }

    }
}
