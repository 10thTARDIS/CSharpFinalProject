﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Final_Project
{
    public class Commissioned : Employee
    {
        public new float gross = 0.0f;
        String ID;

        public Commissioned(String arg_ID)
        {
            ID = arg_ID;
        }
        public Commissioned()
        {

        }
    }
}