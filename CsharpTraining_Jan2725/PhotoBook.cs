using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_Jan2725
{
    public class PhotoBook
    {
        private int numPages;

        public int GetNumberPages(int page)
        {
            return this.numPages = page;
        }
    }
    public class BigPhotoBook
    {
        int pages;

        public BigPhotoBook(int pages)
        {
            this.pages = pages;
            Console.WriteLine("The number of pages in Big photo book " + pages);
        }
    }
}
