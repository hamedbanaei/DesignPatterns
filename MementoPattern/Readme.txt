Memento: A token/handle representing the system state.Lets us toll back to the state 
		when the token was generated. May or may not directly expose state information.

Motivation:
- An object or system goes through changes
	- A bank account gets deposits and withdrawals
- There are different ways of navigating those changes
- One way is to record every change (Command) and teach a command to 'undo' itself
- Another is to simply save snapshots of the system.