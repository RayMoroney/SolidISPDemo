
namespace DemoLibrary.Book
{
    public class ReferenceBook : IBook
    {
        public string Author { get; set; }
        public int Pages { get; set; }
        public string LibraryId { get; set; }
        public string Title { get; set; }
    }
}
