using Final.Interfaces;

namespace Final.Model;

public class Journal : LibraryItem
{
    public DateTime IssueDate { get; set; }
    public string Country { get; set; }
}