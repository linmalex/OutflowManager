﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OutflowManager.Models
{
    public class WishListItem:Transaction
    {
        public float EstAmountHigh { get; set; }
        public float EstAmountLow { get; set; }
    }
}
