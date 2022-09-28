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
                Name = "Xavier Morera",
                Courses = new string[] { "Solr", "Spark", "Jira", "Python" }
            };

            Author lars = new Author()
            {
                Name = "Lars Klint",
                Courses = new string[] { "Windows Phone" }
            };

            Author jason = new Author()
            {
                Name = "Jason Alba",
                Courses = new string[] { "Email", "Soft Skills" }
            };

            xavier.FavoriteAuthors = new List<Author> { xavier, jason, lars, jason };

            string xavierJson = JsonConvert.SerializeObject(xavier, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });

            Console.WriteLine(xavierJson);
        }
    }
}
