namespace FacadeSample;

/// <summary>
/// Subsystem 1: Inventory
/// </summary>
public class InventoryService
{
	public bool CheckStock(int productId, int quantity)
	{
		Console.WriteLine($"Checking stock for Product #{productId}...");

		return true;
	}

	public void ReserveStock(int productId, int quantity)
	{
		Console.WriteLine(
			$"Reserved {quantity} item(s) of Product #{productId}.");
	}
}
