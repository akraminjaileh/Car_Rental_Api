namespace Car_Rental_Api.Models.Entitys
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ModelYear { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public bool IsAvailable { get; set; }

    }
}
