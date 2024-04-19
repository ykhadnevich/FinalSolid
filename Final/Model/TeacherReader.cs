namespace Final.Model;

public class TeacherReader : Reader
{
    public TeacherReader() 
    {
        MaxBooks = 25; 
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