using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ROKO.Library.Entities;
using ROKO.Library.FakeDAL.Interface;

namespace ROKO.Library.FakeDAL
{
    public class BookDAO : IBookDAO
    {
        public IEnumerable<Book> FindAllByPublisherNameTemplateAndGroupByPublisher(string publisherNameTemplate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> FindBooksOfAuthor(string author)
        {
            throw new NotImplementedException();
        }
    }
}
