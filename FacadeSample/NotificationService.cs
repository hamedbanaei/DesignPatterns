namespace FacadeSample;

/// <summary>
/// Subsystem 4: Notification
/// </summary>
public class NotificationService
{
	public void SendOrderConfirmation(string shipmentId, string email)
	{
		Console.WriteLine($"Confirmation sent to {email}. Shipment: {shipmentId}");
	}
}
