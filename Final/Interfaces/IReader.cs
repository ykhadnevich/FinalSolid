namespace Final.Interfaces;

public interface IReader
{
    string UserId { get; set; }
    int MaxBooks { get; set; }
    List<LibraryItem> BorrowedItems { get; }
    void BorrowItem(LibraryItem item);
    void ReturnItem(LibraryItem item);
}


