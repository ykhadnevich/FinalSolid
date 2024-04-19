using Final.Interfaces;

namespace Final.Model;

public class Reader : IReader
{
    public string UserId { get; set; }
    
    public int MaxBooks { get; set; }
    
    public List<LibraryItem> BorrowedItems { get; }
    public void BorrowItem(LibraryItem item)
    {
        throw new NotImplementedException();
    }

    public void ReturnItem(LibraryItem item)
    {
        throw new NotImplementedException();
    }
    
    public virtual void BorrowJournal(Journal journal)
    {
        
        if (BorrowedItems.Count < MaxBooks)
        {
            BorrowedItems.Add(journal);
            journal.AvailableCopies--;
        }
    }
    
    public virtual void ReturnJournal(Journal journal)
    {
        
        if (BorrowedItems.Contains(journal))
        {
            BorrowedItems.Remove(journal);
            journal.AvailableCopies++;
        }
    }
    
    
}