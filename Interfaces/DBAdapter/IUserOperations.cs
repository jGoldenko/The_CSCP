﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface IUserOperations
    {
        IAuthorization IAuthorization { get; set; }
    }
}