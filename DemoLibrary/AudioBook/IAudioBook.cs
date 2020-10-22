using DemoLibrary.GeneralLibraryItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.AudioBook
{
    public interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}
