using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ROKO.Library.Entities;

namespace ROKO.Library.FakeDAL.Interface
{
    public interface IPatentDAO
    {
        IEnumerable<Patent> FindPatentOfInventor(string Inventor);
    }
}
