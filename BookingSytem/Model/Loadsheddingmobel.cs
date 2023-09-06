using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWeather.Model
{
    class Loadsheddingmobel
    {
        public class Cape_Town
        {
            public string name { get; set; }
            public string next_stages { get; set; }
            public int Stage { get; set; }
            public string stage_updated { get; set; }
        }

        public class Eskom 
        {

            public string name { get; set; }
            public string next_stages { get; set; }
            public int Stage { get; set; }
            public string stage_updated { get; set; }
        }

        public class RootObject
        {
            public Cape_Town cape_Town { get; set; }
            public Eskom eskom { get; set; }
        }


    }
}
