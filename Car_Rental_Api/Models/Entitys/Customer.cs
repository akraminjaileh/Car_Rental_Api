namespace Car_Rental_Api.Models.Entitys
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public int NatNationalityID { get; set; }

        public virtual List<Rent> Rent { get; set; }

    }
}
