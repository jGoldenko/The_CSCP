﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface IPay
    {
        event DbListener dbListener;
        void AddDeposit(decimal summ);
    }
}