﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ROKO.Library.Entities;
using ROKO.Library.FakeDAL.Interface;

namespace ROKO.Library.FakeDAL
{
    public class PatentDAO : IPatentDAO
    {
        public IEnumerable<Patent> FindPatentOfInventor(string Inventor)
        {
            throw new NotImplementedException();
        }
    }
}
