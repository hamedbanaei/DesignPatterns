namespace ChainOfResponsibilityPattern;

public class DepartmentManager : LeaveApprover
{
	public override void Approve(LeaveRequest request)
	{
		if (request.Days <= 5)
		{
			Console.WriteLine
				($"Department Manager approved {request.EmployeeName}'s leave.");
		}
		else if (NextApprover is not null)
		{
			NextApprover.Approve(request);
		}
	}
}
