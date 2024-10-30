using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_APP
{
    class WeatherInfo
    {
        public class coord // Create classes based on the JSON to call what we need from the API
        {
            double lon { get; set; } // LOngitude and latitude call from the json
            double lat { get; set; }
        }
        public class weather
        {
            string main { get; set; } // Weather class has three string to be called
            string description  { get; set; }
            string icon { get; set; }
        }
        
        public class main
        {
            double temp  { get; set; } // Main class has 4 double values to be called
            // double feels_like = { get; set; }
            double pressure  { get; set; }
            double humidity { get; set; }
        }
        public class wind
        {
            double speed  { get; set; } // Wind class has one double value to be called, 
            //we can ignore values which we dont want to fetch
        }

        public class sys
        {
            long sunrise  { get; set; } // Sys class has one 64 bit to store so long
            long sunset { get; set; }
        }

        public class Root
        {
            public coord coord { get; set; } // Root class has one string value to be called
            public  List <weather> weather { get; set; } // Need to keep instance as weather is a collection and mutable
            public main main { get; set; } 
            public wind wind { get; set; } 
            public sys sys { get; set; } 
        }
    }
}




        