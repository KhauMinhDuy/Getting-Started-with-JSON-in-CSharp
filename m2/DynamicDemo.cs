﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace m2
{
    public class DynamicDemo
    {
        public static void Show()
        {
            Console.WriteLine("***  Dynamic and ExpandoObject Demo ***");
            dynamic author = new ExpandoObject();
            author.FriendlyName = "Xavier Morera";
            author.Courses = new List<string>() { "Solr", "Spark", "Python", "Jira" };
            author.Happy = true;

            Console.WriteLine("- Serialize");
            /*---------------------------------------------------------*/
            string jsonDynamicAuthor = JsonConvert.SerializeObject(author, Formatting.Indented);
            Console.WriteLine(jsonDynamicAuthor);

            Console.WriteLine("- Deserialize");
            /*---------------------------------------------------------*/
            dynamic authorDeserialized = JsonConvert.DeserializeObject(jsonDynamicAuthor);

            Console.WriteLine("Friendly Name: " + authorDeserialized.FriendlyName);


            dynamic v = JsonConvert.DeserializeObject("{\"name\" : \"123\"}");
            Console.WriteLine($"{v}");
            
        }
    }
}
