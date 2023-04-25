﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Interface forcing us to implement all necesary methods to store all necesary information
    /// </summary>
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel prizeModel);
    }
}
