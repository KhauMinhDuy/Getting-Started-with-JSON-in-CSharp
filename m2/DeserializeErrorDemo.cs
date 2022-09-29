using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonSamples;
using Newtonsoft.Json;

namespace m2
{
    public class DeserializeErrorDemo
    {
        public static void Show()
        {
           Console.WriteLine("*** Deserialize Error ***");
           try
           {
                string jsonDates = Generate.DatesJson();
                List<DateTime> dateTimes = JsonConvert.DeserializeObject<List<DateTime>>(jsonDates);
                Console.WriteLine(dateTimes.Count);
           }    
           catch(Exception e)
           {
                Console.WriteLine($"Unable to deserialize object: {e.Message}");
           } 
        }
    }
}