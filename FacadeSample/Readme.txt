Example: Online Order Checkout

Imagine an e-commerce system. Completing an order requires several subsystems:

InventoryService → checks and reserves stock
PaymentService → processes payment
ShippingService → creates shipment
NotificationService → sends confirmation

Without a Facade, the client must know about all four services.
With a Facade, the client simply calls PlaceOrder().
