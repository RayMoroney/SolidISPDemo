using DemoLibrary.GeneralLibraryItem;

namespace DemoLibrary.Book
{
    public interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}
