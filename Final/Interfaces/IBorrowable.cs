namespace Final.Interfaces;

public interface IBorrowable
{
    int AvailableCopies { get; set; }
    void BorrowItem();
    void ReturnItem();
}

