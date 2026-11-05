namespace ChainOfResponsibilityPattern;

public class TeamLeader : LeaveApprover
{
	public override void Approve(LeaveRequest request)
	{
		if (request.Days <= 2)
		{
			Console.WriteLine
				($"Team Leader approved {request.EmployeeName}'s leave.");
		}
		else if (NextApprover is not null)
		{
			NextApprover.Approve(request);
		}
	}
}
