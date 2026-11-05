// Create handlers
using ChainOfResponsibilityPattern;

var teamLeader = new TeamLeader();
var departmentManager = new DepartmentManager();
var generalManager = new GeneralManager();

// Build the chain
teamLeader.SetNext(departmentManager);
departmentManager.SetNext(generalManager);

// Send requests
var requests = new[]
{
	new LeaveRequest
	{
		EmployeeName = "Ali",
		Days = 2
	},
	new LeaveRequest
	{
		EmployeeName = "Sara",
		Days = 4
	},
	new LeaveRequest
	{
		EmployeeName = "Reza",
		Days = 8
	},
	new LeaveRequest
	{
		EmployeeName = "John",
		Days = 15
	}
};

// Execute or chain for the list
foreach (var request in requests)
{
	teamLeader.Approve(request);
}