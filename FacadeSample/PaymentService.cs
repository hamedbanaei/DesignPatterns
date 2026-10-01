namespace FacadeSample;

/// <summary>
/// Subsystem 2: Payment
/// </summary>
public class PaymentService
{
	public bool ProcessPayment(decimal amount)
	{
		Console.WriteLine($"Processing payment: ${amount}");

		return true;
	}
}
