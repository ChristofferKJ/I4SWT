﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransponderReceiver;

namespace ATM
{
    interface IDecoder
    {
        void Decode(List<string> ddata);

       
    }
}
