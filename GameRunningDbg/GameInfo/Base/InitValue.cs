﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRunningDbg.GameInfo.Base
{
    public interface InitValue<T>
    {
        T InitValue(IntPtr jb);
    }
}
