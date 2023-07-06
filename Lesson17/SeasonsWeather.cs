using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    abstract class SeasonsWeather 
    {
        public virtual void Snow() { }
        public abstract void Rain();   
        public abstract void Hail();
        public abstract void Tycoon();

    }
}
