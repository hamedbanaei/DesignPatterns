namespace ChainOfResponsibilityPattern;

public class GeneralManager : LeaveApprover
{
	public override void Approve(LeaveRequest request)
	{
		if (request.Days <= 10)
		{
			Console.WriteLine
				($"General Manager approved {request.EmployeeName}'s leave.");
		}
		else
		{
			Console.WriteLine($"Leave request for {request.EmployeeName} was rejected.");
		}
	}
}
