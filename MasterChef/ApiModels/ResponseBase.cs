﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChef.API.ApiModels
{
    public class ResponseBase
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
