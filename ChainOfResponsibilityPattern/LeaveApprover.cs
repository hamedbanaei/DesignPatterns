namespace ChainOfResponsibilityPattern;

/// <summary>
/// This abstract class defines the 
/// common behavior of all handlers.
/// </summary>
public abstract class LeaveApprover
{
	protected LeaveApprover? NextApprover;

	public void SetNext(LeaveApprover nextApprover)
	{
		NextApprover = nextApprover;
	}

	public abstract void Approve(LeaveRequest request);
}
