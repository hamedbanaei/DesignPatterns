namespace FacadeSample;

/// <summary>
/// Our Facade Class
/// </summary>
public class OrderFacade
{
	private readonly InventoryService _inventory;
	private readonly PaymentService _payment;
	private readonly ShippingService _shipping;
	private readonly NotificationService _notification;

	public OrderFacade()
	{
		_inventory = new InventoryService();
		_payment = new PaymentService();
		_shipping = new ShippingService();
		_notification = new NotificationService();
	}

	public void PlaceOrder(
		int productId,
		int quantity,
		decimal amount,
		string address,
		string email)
	{
		Console.WriteLine("Starting order process...\n");

		// 1. Check inventory
		if (_inventory.CheckStock(productId, quantity) == false)
		{
			Console.WriteLine("Product is out of stock.");
			return;
		}

		// 2. Reserve inventory
		_inventory.ReserveStock(productId, quantity);

		// 3. Process payment
		if (_payment.ProcessPayment(amount) == false)
		{
			Console.WriteLine("Payment failed.");
			return;
		}

		// 4. Create shipment
		var shipmentId =
			_shipping
			.CreateShipment(productId, address);

		// 5. Notify customer
		_notification
			.SendOrderConfirmation(shipmentId, email);

		Console.WriteLine("\nOrder completed successfully!");
	}
}
