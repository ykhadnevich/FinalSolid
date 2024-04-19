namespace Final.Model;

public class GuestReader : Reader
{
    public GuestReader()
    {
        MaxBooks = 5; 
    }
    
    public override void BorrowJournal(Journal journal)
    {
        if (BorrowedItems.Count < MaxBooks && journal.AvailableCopies > 0)
        {
            BorrowedItems.Add(journal);
            journal.AvailableCopies--;
        }
        else
        {
            // case where the journal cannot be borrowed
        }
    }

    public override void ReturnJournal(Journal journal)
    {
        
        if (BorrowedItems.Contains(journal))
        {
            BorrowedItems.Remove(journal);
            journal.AvailableCopies++;
        }
        else
        {
            // case where the journal cannot be returned
        }
    }
}