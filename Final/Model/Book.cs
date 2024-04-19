using Final.Interfaces;

namespace Final.Model;

public class Book : LibraryItem, IBorrowable
{
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PrintYear { get; set; }
    
    public void BorrowItem()
    {
        if (AvailableCopies > 0)
        {
            AvailableCopies--;
        }
        else
        {
            // bool is not available
        }
    }

    public void ReturnItem()
    {
        AvailableCopies++;
    }
}