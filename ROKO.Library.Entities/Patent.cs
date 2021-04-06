using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROKO.Library.Entities
{
    public class Patent
    {
        public string Title { get; set; }

        public string Inventor { get; set; }

        public string Country { get; set; }

        public int RegistrationNumber { get; set; }

        public DateTime ApplicationDate { get; set; }

        public DateTime PublicationDate { get; set; }

        public int NumberOfPages { get; set; }

        public string Note { get; set; }
    }
}
