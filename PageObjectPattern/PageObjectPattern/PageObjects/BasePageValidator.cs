﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectPattern.PageObjects
{
    public class BasePageValidator<M>
        where M : BasePageElementMap, new()
    {
        protected M Map
        {
            get
            {
                return new M();
            }
        }
    }
}
