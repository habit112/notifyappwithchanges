﻿using HabitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Services.Interfaces
{
    interface IAddHabit
    {
        public bool addHabit(HabitModel habit);


    }
}
