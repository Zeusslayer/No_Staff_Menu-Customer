using System;

namespace No_Staff_Menu_Customer.Models {
    public class OrderModel {
        public int TableId { get; set; }

        public DateTime OrderTime { get; set; }

        public Food Food { get; set; }

        public string Notes { get; set; }
    }

    public class Food {
        public int FoodId { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
    }
}
