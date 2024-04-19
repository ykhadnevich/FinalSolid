namespace Final.Interfaces;

public interface IReaderNotifier
{
    Task Notify(string userId, string message);
}
