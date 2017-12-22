using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloServiceHost.Proxy
{
    public interface IBookParser
    {
        int GetNumPages();
    }

    /// <summary>
    /// concrete resource that has very expensive instantitation 
    /// </summary>
    public class BookParser : IBookParser
    {
        private string _bookUrl;
        public BookParser(string bookUrl)
        {
            _bookUrl = bookUrl;
        }
        public int GetNumPages()
        {
            return _bookUrl.Length;
        }
    }

    /// <summary>
    /// proxy class
    /// </summary>
    public class LazyBookParserProxy : IBookParser
    {
        private string _bookUrl;
        public LazyBookParserProxy(string bookUrl)
        {
            _bookUrl = bookUrl;
        }
        private BookParser _bookParser;

        /// <summary>
        /// instanciation of the book parser only happens only when someone need to call the mathod
        /// insted of having initialized at constructor level
        /// </summary>
        /// <returns></returns>
        public int GetNumPages()
        {
            //use lazy initialization
            if (_bookParser == null)
            {
                _bookParser = new BookParser(_bookUrl);
            }
            return _bookParser.GetNumPages();
        }
    }
}
