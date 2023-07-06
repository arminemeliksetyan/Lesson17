using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    abstract class Weather : SeasonsWeather
    {
        public abstract void Temperature();
        public abstract void Windly();

    }
}
