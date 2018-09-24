﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cardknox.Operations
{
    public class Refund : OperationBase
    {
        public string Operation => CardknoxOperations.CCRefund;

        public string RefNum { get; set; }
        public bool AllowDuplicate { get; set; } = false;
    }
}