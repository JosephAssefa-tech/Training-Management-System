﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
   public  interface BaseModel
    {
        T MapToEntity<T>() where T : class;
    }
}
