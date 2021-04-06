using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ROKO.Library.Entities;
using ROKO.Library.FakeDAL.Interface;
using ROKO.Library.FakeDAL;

namespace ROKO.Library.FakeDAL.Dependencies
{
    public class FakeDALDependencyResolver
    {
        private static IBookDAO _bookDAO;

        private static INewspaperDAO _newspaperDAO;

        private static IPatentDAO _patentDAO;

        private static ICatalogDAO _catalogDAO;

        public static IBookDAO BookDAO => _bookDAO ?? (_bookDAO = new BookDAO());

        public static INewspaperDAO NewspaperDAO => _newspaperDAO ?? (_newspaperDAO = new NewspaperDAO());

        public static IPatentDAO PatentDAO => _patentDAO ?? (_patentDAO = new PatentDAO());

        public static ICatalogDAO CatalogDAO => _catalogDAO ?? (_catalogDAO = new CatalogDAO());

    }
}
