using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Chart.Model
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }
    }
}
