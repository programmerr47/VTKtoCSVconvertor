﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTKtoCSVconvertor
{
    interface FormObserver
    {
        void updateSourceNameLabel();
        void updatePointsNumberLabel();
    }
}
