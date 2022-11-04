﻿using Christmas.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas.Entities
{
    public class BallFactory : IToyFactory
    {
        public BallFactory()
        {

        }

        public Toy CreateNew()
        {
            throw new NotImplementedException();
        }

        public Toy CreteNew()
        {
            return new Ball();
        }
    }
}
