using design_patterns.Proxy;
using System.ComponentModel;

namespace design_patterns.Proxy
{
    //Allows providing a substitute for another object. The proxy object delegates all the work to the target object and contains some additional behavior.

    public class EbookProxy : IEbook
    {
        private string fileName;
        private Ebook ebook;

        public EbookProxy(string fileName)
        {
            this.fileName = fileName;
        }
        public string GetFileName()
        {
            return fileName;
        }

        public void Show()
        {
            if(ebook ==  null)
            {
                ebook = new Ebook(fileName);
            }
            ebook.Show();
        }
    }
}


////Proxy design Pattern
////Lazy loading uses this pattern

//using design_patterns.Proxy;
//using System.Runtime.CompilerServices;


////var library = new Library();

////var filenames = new string[] { "a", "b", "c" };

////foreach (var filename in filenames)
////{
////    library.Add(new Ebook(filename));
////}

////library.OpenEbook("a");

////Console Result 

//// Loading the ebook a                     //Loads all the ebook but only opens one of it .
////Loading the ebook b
////Loading the ebook c
////Showing the ebook a


//var libProxy = new Library();

//var fileNames = new string[] { "a", "b", "c" };

//foreach (var filename in fileNames)
//{
//    libProxy.Add(new EbookProxy(filename));
//}

//libProxy.OpenEbook("a");

////Console Result

////Loading the ebook a
////Showing the ebook a

////var logProxy = new Library();

////var fileNames1 = new string[] { "a", "b", "c" };

////foreach (var filename in fileNames1)
////{
////    logProxy.Add(new LoggingEbookProxy(filename));
////}

////logProxy.OpenEbook("a");
////logProxy.OpenEbook("b");

//////Console Result

//////Logging Ebook a
//////Loading the ebook a
//////Showing the ebook a
//////Loading the ebook b
//////Logging Ebook b
//////Showing the ebook b