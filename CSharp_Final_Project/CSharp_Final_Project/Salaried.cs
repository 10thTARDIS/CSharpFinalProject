﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Final_Project
{
    public class Salaried : Employee
    {
        public new float gross = 0.0f;
        String ID;

        public Salaried(String arg_ID)
        {
            ID = arg_ID;
        }
        public Salaried()
        {

        }
    }
}
