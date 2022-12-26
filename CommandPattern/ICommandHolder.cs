namespace CommandPattern
{
    internal interface ICommandHolder
    {
        ICommand Command { get; set; }
    }
}
