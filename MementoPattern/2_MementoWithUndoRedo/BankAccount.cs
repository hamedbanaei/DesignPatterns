namespace MementoWithUndoRedo;

public class BankAccount
{
    private int _balance;
    private int _pointer = 0;
    private List<Memento> _history = new List<Memento>();

    public BankAccount(int balance)
    {
        this._balance = balance;
        _history.Add(new Memento(balance));
    }

    public Memento Deposit(int amount)
    {
        _balance += amount;
        var m = new Memento(_balance);
        _history.Add(m);
        _pointer++;

        return m;
    }

    public void Restore(Memento m)
    {
        if (m != null)
        {
            _balance = m.Balance;
            _history.Add(m);
            _pointer = _history.Count - 1;
        }
    }

    public Memento Undo()
    {
        if (_pointer > 0)
        {
            _pointer--;
            var m = _history[_pointer];
            _balance = m.Balance;
            return m;
        }

        return null;
    }

    public Memento Redo()
    {
        if (_pointer + 1 < _history.Count)
        {
            _pointer++;
            var m = _history[_pointer];
            _balance = m.Balance;
            return m;
        }

        return null;
    }

    public override string ToString()
    {
        return $"Balance: {_balance}";
    }
}
