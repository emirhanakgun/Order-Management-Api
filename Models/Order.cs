namespace OrderManagementAPI.Models

{
public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public List<OrderItem> OrderItems { get; set; }
        public int UserId { get; set; }
    }
}