using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ROKO.Library.Entities;

namespace ROKO.Library.FakeDAL.Interface
{
    public interface ICatalogDAO
    {
        void AddBook(Book book);

        void AddNewspaper(Newspaper newspaper);

        void AddPatent(Patent patent);

        void DeleteBook(string ISBN);

        void DeleteNewspaper(string ISSN);

        void DeletePatent(int registrationNumber, string country);

        void GetCatalog();

        void GetRecordByTitle(string identificator);

        void AscSort();

        void DescSort();

        void FindBooksAndPatentsOfAuthor(string author);

        void GroupRecordsByYear();
    }
}
