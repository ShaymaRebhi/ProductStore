﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Chemical : Product
    {
        public string City { get; set; }
        {
            base.GetMyType();
            Console.WriteLine("chemical");
        }
}