﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ResponeModel
{
    public class ResponeModel
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }

        public class TokenExpireTime() : ResponeModel
        {
            public DateTime Expiration { get; set; }
        }
    }
}