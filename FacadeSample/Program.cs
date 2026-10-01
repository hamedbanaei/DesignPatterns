using FacadeSample;

var orderFacade = new OrderFacade();

orderFacade.PlaceOrder(
	productId: 101,
	quantity: 2,
	amount: 150.00m,
	address: "New York, NY",
	email: "customer@example.com");