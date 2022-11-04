using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas.Entities
{
    public class BallFactory
    {
        public BallFactory()
        {

        }

        public Ball CreteNew()
        {
            return new Ball();
        }
    }
}
