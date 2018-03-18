namespace MyCafe.BLL.DTO
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        public int FirmId { get; set; }
        public FirmDTO Firm { get; set; }
        public string Name { get; set; }
    }
}