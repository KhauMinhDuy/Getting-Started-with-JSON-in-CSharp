using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace m2
{
    public class JsonSerializerDemo
    {
        public static void Show()
        {
            // Console.Clear();
            Console.WriteLine("*** JsonSerializer Demo ***");

            Author xavier = new Author()
            {
                Name = "Xavier Morera",
                Courses = new string[] { "Solr", "Spark", "Jira" },
                Happy = true,
                Since = new DateTime(2014, 01, 15)
            };

            Console.WriteLine("Step 1: Serialize JSON with default settings");
            using(StreamWriter sw = new StreamWriter(@"1-defaultsettings.json")) 
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(sw, xavier);
            }

            Console.WriteLine("Step 2: Serialize JSON with indented true");
            using(StreamWriter sw = new StreamWriter(@"2-indented.json")) 
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(sw, xavier);
            }

            Console.WriteLine("Step 3: Serialize JSON with ignore nulls");
            using (StreamWriter sw = new StreamWriter(@"3-ignorenulls.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.NullValueHandling = NullValueHandling.Ignore;
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(sw, xavier);
            }

            Console.WriteLine("Curious about size difference?");
            FileInfo defaultsettings = new FileInfo(@"1-defaultsettings.json");
            Console.WriteLine($"Size of file 1-defaultsettings.json: {defaultsettings.Length} bytes");

            FileInfo indented = new FileInfo(@"2-indented.json");
            Console.WriteLine($"Size of file 2-indented.json: {indented.Length} bytes");

            FileInfo ignorenulls = new FileInfo(@"3-ignorenulls.json");
            Console.WriteLine($"Size of file 3-ignorenulls.json: {ignorenulls.Length} bytes");
            
        }
    }
}