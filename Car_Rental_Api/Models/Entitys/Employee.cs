﻿namespace Car_Rental_Api.Models.Entitys
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public virtual List<Car> Car { get; set; }

    }
}
