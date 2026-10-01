namespace FacadeSample;

/// <summary>
/// Subsystem 3: Shipping
/// </summary>
public class ShippingService
{
	public string CreateShipment(int productId, string address)
	{
		Console.WriteLine($"Creating shipment for Product #{productId}...");
		Console.WriteLine($"Shipping to: {address}");

		return $"SHIP-{System.Guid.CreateVersion7()}";
	}
}
