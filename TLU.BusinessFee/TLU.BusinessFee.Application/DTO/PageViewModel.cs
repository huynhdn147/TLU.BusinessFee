﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.DTO
{
   public class PageViewModel<T>
    {
        public List<T> Items { set; get; }
        public int TotalRecord { set; get; }
    }
}
