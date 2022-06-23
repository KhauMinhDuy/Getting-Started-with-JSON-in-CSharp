using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2
{
    public class ObjectReferencesDemo
    {
        public static void Show()
        {
            //Console.Clear();
            Console.WriteLine("*** Object References Demo ***");

            Author xavier = new Author()
            {
                name = "Xavier Morera",
                courses = new string[] { "Solr", "Spark", "Jira", "Python" }
            };

            Author lars = new Author()
            {
                name = "Lars Klint",
                courses = new string[] { "Windows Phone" }
            };

            Author jason = new Author()
            {
                name = "Jason Alba",
                courses = new string[] { "Email", "Soft Skills" }
            };

            xavier.favoriteAuthors = new List<Author> { xavier, jason, lars, jason };

            string xavierJson = JsonConvert.SerializeObject(xavier, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });

            Console.WriteLine(xavierJson);
        }
    }
}
