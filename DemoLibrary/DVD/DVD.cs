using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.DVD
{
    public class DVD : IBorrowableDVD
    {
        public List<string> Actors { get; set; }
        public int RuntimeInMinutes { get; set; }
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; }
        public int CheckOutDurationInDays { get; set; }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public void CheckIn()
        {
            Borrower = "";
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationInDays);
        }
    }
}
