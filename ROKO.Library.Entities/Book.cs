using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROKO.Library.Entities
{
    public class Book : LibraryObject
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string PlaceOfPublication { get; set; }

        public string PublishingHouse { get; set; }

        public DateTime PublicationYear { get; set; }

        public int NumberOfPages { get; set; }

        public string Note { get; set; }

        public string ISBN { get; set; }
    }
}
