namespace MyCafe.DB.Enities
{
    public class Department
    {
        public int Id { get; set; }
        public int FirmId { get; set; }
        public Firm Firm { get; set; }

    }
}
