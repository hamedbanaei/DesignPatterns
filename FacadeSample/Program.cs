using FacadeSample;

// ********** ********** ********** ********** **********
// Without the Facade: The client need to understand the entire subsystem
// ********** ********** ********** ********** **********

{
	var inventory = new InventoryService();
	var payment = new PaymentService();
	var shipping = new ShippingService();
	var notification = new NotificationService();

	if (inventory.CheckStock(101, 2))
	{
		inventory.ReserveStock(101, 2);

		if (payment.ProcessPayment(150))
		{
			var shipmentId =
				shipping.CreateShipment(
					101,
					"New York, NY");

			notification.SendOrderConfirmation(
				shipmentId,
				"customer@example.com");
		}
	}
}

// ********** ********** ********** ********** **********
// / Without the Facade: The client need to understand the entire subsystem.
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// With the Facade: The client only needs to know PlaceOrder method.
// ********** ********** ********** ********** **********

{
	var orderFacade = new OrderFacade();

	orderFacade.PlaceOrder(
		productId: 101,
		quantity: 2,
		amount: 150.00m,
		address: "New York, NY",
		email: "customer@example.com");
}

// ********** ********** ********** ********** **********
// With the Facade: The client only needs to know PlaceOrder method.
// ********** ********** ********** ********** **********