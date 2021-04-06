using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ROKO.Library.Entities;
using ROKO.Library.FakeDAL.Interface;

namespace ROKO.Library.FakeDAL
{
    public class CatalogDAO : ICatalogDAO
    {
        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void AddNewspaper(Newspaper newspaper)
        {
            throw new NotImplementedException();
        }

        public void AddPatent(Patent patent)
        {
            throw new NotImplementedException();
        }

        public void AscSort()
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(string ISBN)
        {
            throw new NotImplementedException();
        }

        public void DeleteNewspaper(string ISSN)
        {
            throw new NotImplementedException();
        }

        public void DeletePatent(int registrationNumber, string country)
        {
            throw new NotImplementedException();
        }

        public void DescSort()
        {
            throw new NotImplementedException();
        }

        public void FindBooksAndPatentsOfAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public void GetCatalog()
        {
            throw new NotImplementedException();
        }

        public void GetRecordByTitle(string identificator)
        {
            throw new NotImplementedException();
        }

        public void GroupRecordsByYear()
        {
            throw new NotImplementedException();
        }
    }
}
