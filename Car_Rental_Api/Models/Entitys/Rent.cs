namespace Car_Rental_Api.Models.Entitys
{
    public class Rent
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public virtual Car Car { get; set; }
        public virtual Customer  Customer { get; set; }

    }
}
